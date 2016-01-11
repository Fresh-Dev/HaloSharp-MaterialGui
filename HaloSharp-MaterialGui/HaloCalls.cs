// ***********************************************************************
// Assembly         : HaloApiTest
// Author           : Kevin Kleinjung
// Created          : 01-09-2016
//
// Last Modified By : Kevin Kleinjung
// Last Modified On : 01-09-2016
// ***********************************************************************
// <copyright file="HaloCalls.cs" company="Fresh-Dev">
//     Copyright © Kevin Kleinjung 2016
// </copyright>
// <summary>Halo-API Calls for Mainform</summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaloSharp;
using HaloSharp.Extension;
using HaloSharp.Model.Metadata;
using HaloSharp.Model.Stats.Lifetime;
using HaloSharp.Query.Metadata;
using HaloSharp.Query.Profile;
using HaloSharp.Query.Stats.Lifetime;
using MaterialHaloSharp.Properties;
using Newtonsoft.Json;
using Tulpep.NotificationWindow;

namespace MaterialHaloSharp
{
    /// <summary>
    /// Class Mainform.
    /// </summary>
    public partial class Mainform
    {
        

        //Main-Querys (Define them Public, and update them at first Api-Call (may after GetMetadata if u want) and Update them on every global value update. If u update them to often / to fast, you'll get API-Limit exeed error)
        public CustomServiceRecord CustomServiceRecord;
        public WarzoneServiceRecord WarzoneServiceRecord;
        public ArenaServiceRecord ArenaServiceRecord;
        public CampaignServiceRecord CampaignServiceRecord;

        /// <summary>
        /// Gets the global halo5 meta data.
        /// </summary>
        public async void GetGlobalMetaData()
        {
            var client = new HaloClient(DevAcc);

            if (!Tools.FileExists("MetaSpartanRanks.bin") || !Tools.FileExists("MetaMaps.bin") || !Tools.FileExists("MetaMedals.bin") || !Tools.FileExists("MetaWeapons.bin"))
                {
                using (var session = client.StartSession())
                {
                    SpartanRanks = await session.Query(new GetSpartanRanks());
                    Tools.WriteToBinaryFile("MetaSpartanRanks.bin",SpartanRanks);

                    Maps = await session.Query(new GetMaps());
                    Tools.WriteToBinaryFile("MetaMaps.bin", Maps);

                    Medals = await session.Query(new GetMedals());
                    Tools.WriteToBinaryFile("MetaMedals.bin", Medals);

                    Weapons = await session.Query(new GetWeapons());
                    Tools.WriteToBinaryFile("MetaWeapons.bin", Weapons);

                    Settings.Default.MetaDataLastUpdated = DateTime.Now;
                    Settings.Default.Save();

                    Tools.ShowNotification("Metadata Updated!", "The Metadata-Databases for SpartanRanks, Maps, Medals, Weapons and Vehicles is now up-to-date!");
                }
            }
            else
            {
                try { SpartanRanks = Tools.ReadFromBinaryFile <List<SpartanRank>>("MetaSpartanRanks.bin"); }
                catch (Exception e)
                {
                    using (var session = client.StartSession()){SpartanRanks = await session.Query(new GetSpartanRanks());}
                    Tools.WriteToBinaryFile("MetaSpartanRanks.bin", SpartanRanks);
                    Tools.ShowNotification("SpartanRanks Updated!", "The Metadata-Databases for SpartanRanks has been updated!\nDatabase-File had an error!");
                }

                try { Medals = Tools.ReadFromBinaryFile<List<Medal>>("MetaMedals.bin"); }
                catch (Exception e)
                {
                    using (var session = client.StartSession()) { Medals = await session.Query(new GetMedals()); }
                    Tools.WriteToBinaryFile("MetaMedals.bin", Medals);
                    Tools.ShowNotification("Medals Updated!", "The Metadata-Databases for Medals has been updated!\nDatabase-File had an error!");
                }

                try { Maps = Tools.ReadFromBinaryFile<List<Map>>("MetaMaps.bin"); }
                catch (Exception e)
                {
                    using (var session = client.StartSession()) { Maps = await session.Query(new GetMaps()); }
                    Tools.WriteToBinaryFile("MetaMaps.bin", Maps);
                    Tools.ShowNotification("Maps Updated!", "The Metadata-Databases for Maps has been updated!\nDatabase-File had an error!");
                }

                try { Weapons = Tools.ReadFromBinaryFile<List<Weapon>>("MetaWeapons.bin"); }
                catch (Exception e)
                {
                    using (var session = client.StartSession()) { Weapons = await session.Query(new GetWeapons()); }
                    Tools.WriteToBinaryFile("MetaWeapons.bin", Weapons);
                    Tools.ShowNotification("Weapons Updated!", "The Metadata-Databases for Weapons has been updated!\nDatabase-File had an error!");
                }
            }
            MetaDataLoaded = true;

            //Call the next API-Set Call
            UpdateOverview();
        }


        /// <summary>
        /// Get the Customstats.
        /// </summary>
        public async void UpdateOverview()
        {
            var client = new HaloClient(DevAcc);

            using (var session = client.StartSession())
            {
                // Get the current Base-Informations
                CustomServiceRecord = await session.Query(new GetCustomServiceRecord().ForPlayer(Gamertag));
                WarzoneServiceRecord = await session.Query(new GetWarzoneServiceRecord().ForPlayer(Gamertag));
                ArenaServiceRecord = await session.Query(new GetArenaServiceRecord().ForPlayer(Gamertag));
                CampaignServiceRecord = await session.Query(new GetCampaignServiceRecord().ForPlayer(Gamertag));

                // Calculate the "All-Modes" total played time
                var totalPlayTime = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalTimePlayed +
                                    ArenaServiceRecord.Results[0].Result.ArenaStats.TotalTimePlayed +
                                    CampaignServiceRecord.Results[0].Result.CampaignStat.TotalTimePlayed;

                // Parse the total played time to a custom string
                var totalPlayTimeString = $"{totalPlayTime.Days}D {totalPlayTime.Hours}Hr {totalPlayTime.Minutes}Min";

                // Calculate the "All-Modes" total kills
                var totalKills = CustomServiceRecord.Results[0].Result.CustomStats.TotalKills +
                                 WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalKills +
                                 ArenaServiceRecord.Results[0].Result.ArenaStats.TotalKills;

                // Calculate the "All-Modes" total deaths
                var totalDeath = CustomServiceRecord.Results[0].Result.CustomStats.TotalDeaths +
                                 WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalDeaths +
                                 ArenaServiceRecord.Results[0].Result.ArenaStats.TotalDeaths;

                // Calculate the "All-Modes" total assists
                var totalAssists = CustomServiceRecord.Results[0].Result.CustomStats.TotalAssists +
                                   WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalAssists +
                                   ArenaServiceRecord.Results[0].Result.ArenaStats.TotalAssists;

                // Calculate the "All-Modes" total headshots
                var totalHeadshots = CustomServiceRecord.Results[0].Result.CustomStats.TotalHeadshots +
                                     WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalHeadshots +
                                     ArenaServiceRecord.Results[0].Result.ArenaStats.TotalHeadshots;

                // Calculate the "All-Modes" total TotalShots
                var totalShotsFired = CustomServiceRecord.Results[0].Result.CustomStats.TotalShotsFired +
                                      WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalShotsFired +
                                      ArenaServiceRecord.Results[0].Result.ArenaStats.TotalShotsFired;

                // Calculate the "All-Modes" total headshots
                var totalShotsLanded = CustomServiceRecord.Results[0].Result.CustomStats.TotalShotsLanded +
                                       WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalShotsLanded +
                                       ArenaServiceRecord.Results[0].Result.ArenaStats.TotalShotsLanded;

                // Calculate the "All-Modes" total assassinations
                var totalAssassinations = CustomServiceRecord.Results[0].Result.CustomStats.TotalAssassinations +
                                          WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalAssassinations +
                                          ArenaServiceRecord.Results[0].Result.ArenaStats.TotalAssassinations;

                // Calculate the "All-Modes" total game-counts
                var totalGames = CustomServiceRecord.Results[0].Result.CustomStats.TotalGamesCompleted +
                                 WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesCompleted +
                                 ArenaServiceRecord.Results[0].Result.ArenaStats.TotalGamesCompleted;

                // Calculate the "All-Modes" total wins
                var totalWon = CustomServiceRecord.Results[0].Result.CustomStats.TotalGamesWon +
                               WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesWon +
                               ArenaServiceRecord.Results[0].Result.ArenaStats.TotalGamesWon;

                // Calculate the "All-Modes" total losts
                var totalLost = CustomServiceRecord.Results[0].Result.CustomStats.TotalGamesLost +
                                WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesLost +
                                ArenaServiceRecord.Results[0].Result.ArenaStats.TotalGamesLost;

                // Grab gamers current SpartanRank
                var currentSpartanRank = CustomServiceRecord.Results[0].Result.SpartanRank;

                // Grab gamers current XP
                var currentSpartanXp = CustomServiceRecord.Results[0].Result.Xp;

                // Grab gamers current SpartanRank's progress percentage
                var percentSpartanRankCurrent = SpartanRankGetPercentage(currentSpartanXp,currentSpartanRank);

                // Grab gamers current emblem
                var playerImgEmblem =
                    await session.Query(new GetEmblemImage().ForPlayer(Gamertag));

                // Grab gamers current avatar
                var playerImgSpartanImage =
                    await session.Query(new GetSpartanImage().ForPlayer(Gamertag));

                // Calculate total Kill / Death
                float totalKillsDeath = totalKills/(float) totalDeath;

                // Calculate total Kill+Assist / Death
                float totalKillsWithAssistsDeath = (totalKills + (float) totalAssists)/totalDeath;

                // Calculate TotalShot Accuracy
                float playersTotalAccuracy = 100*(totalShotsLanded/(float) totalShotsFired);

                TopMedals = WarzoneServiceRecord.Results[0].Result.WarzoneStat.MedalAwards;
                TopMedals.AddRange(ArenaServiceRecord.Results[0].Result.ArenaStats.MedalAwards.ToList());
                TopMedals=TopMedals.OrderByDescending(o => o.Count).ToList();


                //UI-Updates
                UiSetPlayerEmblem(playerImgEmblem.Image, pictureBox1);
                UiSetPlayerSpartanImage(playerImgSpartanImage.Image, pictureBox2);
                UiUpdateLabel(Resources.prefixSrWithSpace + currentSpartanRank, l_rank_);
                UiUpdateLabel(Gamertag, l_gamertag_, Color.White);
                UiUpdateLabel(Resources.prefixTotalTimePlayedWithNewline + totalPlayTimeString, l_time_played);
                UiUpdateLabel("Kills: \t" + totalKills.ToString("#,###"), l_totalKills);
                UiUpdateLabel("Deaths: \t" + totalDeath.ToString("#,###"), l_totalDeaths);
                UiUpdateLabel("Assists: \t" + totalAssists.ToString("#,###"), l_totalAssists);
                UiUpdateLabel("K/D: \t" + totalKillsDeath.ToString("0.00"), l_killsDeath);
                UiUpdateLabel("K+A/D: \t" + totalKillsWithAssistsDeath.ToString("0.00"), l_killsAssistsDeath);
                UiUpdateLabel("Headshots: \t" + totalHeadshots.ToString("#,###"), l_headshots);
                UiUpdateLabel("Assassinations: \t" + totalAssassinations.ToString("#,###"), l_assassinations);
                UiUpdateLabel("Total Match-Count: \t" + totalGames.ToString("#,###"), l_totalMatchesCount);
                UiUpdateLabel("Total Matches Won: \t" + totalWon.ToString("#,###"), l_totalMatchesWon, Color.DarkGreen);
                UiUpdateLabel("Total Matches Lost: \t" + totalLost.ToString("#,###"), l_totalMatchesLost, Color.Red);
                UiUpdateLabel("Total Shots Fired: \t" + totalShotsFired.ToString("#,###"), l_totalShotsFired);
                UiUpdateLabel("Total Shots Landed: \t" + totalShotsLanded.ToString("#,###"), l_totalShotsLanded);
                UiUpdateLabel("Shot Accuracy: \t" + playersTotalAccuracy.ToString("0.00") + " %", l_totalShotsAccuracy);
                Invoke((MethodInvoker)delegate {
                    circularProgressBar1.Caption = Resources.prefixSrWithSpace + "\n" + percentSpartanRankCurrent.ToString("0.00") + " %";
                    circularProgressBar1.Value = (float)(percentSpartanRankCurrent);
                });


                var bitmap2 = Tools.BitmapFromUrl(Tools.GetMedalFromMedalList(Medals, TopMedals[0].MedalId).SpriteLocation.SpriteSheetUri);
                for (var max = 0; max < 10; max++)
                {
                    var medalx = Tools.GetMedalFromMedalList(Medals, TopMedals[max].MedalId);
                    var cloneRect = Tools.MedalSpriteRectangle(medalx);
                    var cloneBitmap = Tools.GetSpriteFromImage(bitmap2, cloneRect);
                    Invoke((MethodInvoker)delegate { TopMedalPicBoxes[max].Image = Tools.ScaleImage(cloneBitmap, 64, 64); });
                    UiUpdateLabel(Medals.First(item => item.Id == TopMedals[max].MedalId).Name + "\n[ " + TopMedals[max].Count.ToString("#,###") + " ]", TopMedalLabels[max]);
                }
                
                
            }
            UpdateWarzone();
        }

        public async void UpdateWarzone()
        {

            var client = new HaloClient(DevAcc);
            using (var session = client.StartSession())
            {
                var totalPlayTime = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalTimePlayed;
                
                // Parse the total played time to a custom string
                var totalPlayTimeString = $"{totalPlayTime.Days}D {totalPlayTime.Hours}Hr {totalPlayTime.Minutes}Min";

                // Calculate the "Warzone" total kills
                var totalKills = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalKills;

                // Calculate the "Warzone" total deaths
                var totalDeath = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalDeaths;

                // Calculate the "Warzone" total assists
                var totalAssists = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalAssists;

                // Calculate the "Warzone" total headshots
                var totalHeadshots = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalHeadshots;

                // Calculate the "Warzone" total TotalShots
                var totalShotsFired = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalShotsFired;

                // Calculate the "Warzone" total headshots
                var totalShotsLanded = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalShotsLanded;

                // Calculate the "Warzone" total assassinations
                var totalAssassinations = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalAssassinations;

                // Calculate the "Warzone" total game-counts
                var totalGames = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesCompleted;

                // Calculate the "Warzone" total wins
                var totalWon = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesWon;

                // Calculate the "Warzone" total losts
                var totalLost = WarzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesLost;

                // Calculate total Kill / Death
                float totalKillsDeath = totalKills / (float)totalDeath;

                // Calculate total Kill+Assist / Death
                float totalKillsWithAssistsDeath = (totalKills + (float)totalAssists) / totalDeath;

                // Calculate TotalShot Accuracy
                float playersTotalAccuracy = 100 * (totalShotsLanded / (float)totalShotsFired);

                TopMedals = WarzoneServiceRecord.Results[0].Result.WarzoneStat.MedalAwards;
                TopMedals = TopMedals.OrderByDescending(o => o.Count).ToList();

                WarzoneTopWeapons = WarzoneServiceRecord.Results[0].Result.WarzoneStat.WeaponStats;
                WarzoneTopWeapons = WarzoneTopWeapons.OrderByDescending(o => o.TotalKills).ToList();

                var MedalsSpriteImage = Tools.BitmapFromUrl(Tools.GetMedalFromMedalList(Medals, TopMedals[0].MedalId).SpriteLocation.SpriteSheetUri);

                
                

                
                

                for (var max = 0; max < 5; max++)
                {
                    //Medal-Stuff
                    var medalx = Tools.GetMedalFromMedalList(Medals, TopMedals[max].MedalId);
                    var cloneRect = Tools.MedalSpriteRectangle(medalx);
                    var cloneBitmap = Tools.GetSpriteFromImage(MedalsSpriteImage, cloneRect);
                    Invoke((MethodInvoker)delegate { WarzoneTopMedalPicBoxes[max].Image = Tools.ScaleImage(cloneBitmap, 64, 64); });
                    UiUpdateLabel(Medals.First(item => item.Id == TopMedals[max].MedalId).Name + "\n[ " + TopMedals[max].Count.ToString("#,###") + " ]", WarzoneTopMedalLabels[max]);
                    
                    //Weapon-Stuff
                    var WeaponImage = Tools.BitmapFromUrl(Tools.GetWeaponFromWeaponList(Weapons, WarzoneTopWeapons[max].WeaponId.StockId).SmallIconImageUrl);
                    var WeaponName = Tools.GetWeaponFromWeaponList(Weapons, WarzoneTopWeapons[max].WeaponId.StockId).Name;
                    var WeaponKills = WarzoneTopWeapons[max].TotalKills;

                    Invoke((MethodInvoker) delegate
                    {
                        WarzoneTopWeaponsPicBoxes[max].Image = Tools.ScaleImage(WeaponImage, 64, 64);
                    });
                    UiUpdateLabel(WeaponName + "\n[ " + WeaponKills.ToString("#,###") + " ]", WarzoneTopWeaponsLabels[max]);
                }
                
            }
        }


        private static
            void AntiAliasLabel(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            Graphics g2 = e.Graphics;
            Font fnt = lbl.Font;
            g2.TextRenderingHint = TextRenderingHint.AntiAlias;
            g2.DrawString(lbl.Text, fnt, Brushes.LightGray, 0, 0);
        }


    }

    }

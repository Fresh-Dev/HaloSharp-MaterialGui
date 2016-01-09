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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using HaloSharp;
using HaloSharp.Extension;
using HaloSharp.Model.Metadata;
using HaloSharp.Model.Stats;
using HaloSharp.Model.Stats.Common;
using HaloSharp.Query.Metadata;
using HaloSharp.Query.Stats.Lifetime;
using MaterialHaloSharp.Properties;
using ObjectDumper;

namespace MaterialHaloSharp
{
    /// <summary>
    /// Class Mainform.
    /// </summary>
    public partial class Mainform
    {
        //Main-Querys
        public HaloSharp.Model.Stats.Lifetime.CustomServiceRecord customServiceRecord;
        public HaloSharp.Model.Stats.Lifetime.WarzoneServiceRecord warzoneServiceRecord;
        public HaloSharp.Model.Stats.Lifetime.ArenaServiceRecord arenaServiceRecord;
        public HaloSharp.Model.Stats.Lifetime.CampaignServiceRecord campaignServiceRecord;

        /// <summary>
        /// Gets the global halo5 meta data.
        /// </summary>
        public async void GetGlobalMetaData()
        {
            var client = new HaloClient(DevAcc);
            using (var session = client.StartSession())
            {
                SpartanRanks = await session.Query(new GetSpartanRanks());
                Maps = await session.Query(new GetMaps());
                Commendations = await session.Query(new GetCommendations());
                Medals = await session.Query(new GetMedals());
            }

            MetaDataLoaded = true;
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
                customServiceRecord = await session.Query(new GetCustomServiceRecord().ForPlayer(Gamertag));
                warzoneServiceRecord = await session.Query(new GetWarzoneServiceRecord().ForPlayer(Gamertag));
                arenaServiceRecord = await session.Query(new GetArenaServiceRecord().ForPlayer(Gamertag));
                campaignServiceRecord = await session.Query(new GetCampaignServiceRecord().ForPlayer(Gamertag));

                // Calculate the "All-Modes" total played time
                var totalPlayTime = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalTimePlayed +
                                    arenaServiceRecord.Results[0].Result.ArenaStats.TotalTimePlayed +
                                    campaignServiceRecord.Results[0].Result.CampaignStat.TotalTimePlayed;

                // Parse the total played time to a custom string
                var totalPlayTimeString = $"{totalPlayTime.Days}D {totalPlayTime.Hours}Hr {totalPlayTime.Minutes}Min";

                // Calculate the "All-Modes" total kills
                var totalKills = customServiceRecord.Results[0].Result.CustomStats.TotalKills +
                                 warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalKills +
                                 arenaServiceRecord.Results[0].Result.ArenaStats.TotalKills;

                // Calculate the "All-Modes" total deaths
                var totalDeath = customServiceRecord.Results[0].Result.CustomStats.TotalDeaths +
                                 warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalDeaths +
                                 arenaServiceRecord.Results[0].Result.ArenaStats.TotalDeaths;

                // Calculate the "All-Modes" total assists
                var totalAssists = customServiceRecord.Results[0].Result.CustomStats.TotalAssists +
                                   warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalAssists +
                                   arenaServiceRecord.Results[0].Result.ArenaStats.TotalAssists;

                // Calculate the "All-Modes" total headshots
                var totalHeadshots = customServiceRecord.Results[0].Result.CustomStats.TotalHeadshots +
                                     warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalHeadshots +
                                     arenaServiceRecord.Results[0].Result.ArenaStats.TotalHeadshots;

                // Calculate the "All-Modes" total TotalShots
                var totalShotsFired = customServiceRecord.Results[0].Result.CustomStats.TotalShotsFired +
                                      warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalShotsFired +
                                      arenaServiceRecord.Results[0].Result.ArenaStats.TotalShotsFired;

                // Calculate the "All-Modes" total headshots
                var totalShotsLanded = customServiceRecord.Results[0].Result.CustomStats.TotalShotsLanded +
                                       warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalShotsLanded +
                                       arenaServiceRecord.Results[0].Result.ArenaStats.TotalShotsLanded;

                // Calculate the "All-Modes" total assassinations
                var totalAssassinations = customServiceRecord.Results[0].Result.CustomStats.TotalAssassinations +
                                          warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalAssassinations +
                                          arenaServiceRecord.Results[0].Result.ArenaStats.TotalAssassinations;

                // Calculate the "All-Modes" total game-counts
                var totalGames = customServiceRecord.Results[0].Result.CustomStats.TotalGamesCompleted +
                                 warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesCompleted +
                                 arenaServiceRecord.Results[0].Result.ArenaStats.TotalGamesCompleted;

                // Calculate the "All-Modes" total wins
                var totalWon = customServiceRecord.Results[0].Result.CustomStats.TotalGamesWon +
                               warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesWon +
                               arenaServiceRecord.Results[0].Result.ArenaStats.TotalGamesWon;

                // Calculate the "All-Modes" total losts
                var totalLost = customServiceRecord.Results[0].Result.CustomStats.TotalGamesLost +
                                warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesLost +
                                arenaServiceRecord.Results[0].Result.ArenaStats.TotalGamesLost;

                // Grab gamers current SpartanRank
                var currentSpartanRank = customServiceRecord.Results[0].Result.SpartanRank;

                // Grab gamers current XP
                var currentSpartanXp = customServiceRecord.Results[0].Result.Xp;

                // Grab gamers current SpartanRank's progress percentage
                var percentSpartanRankCurrent = SpartanRankGetPercentage(currentSpartanXp);

                // Grab gamers current emblem
                var playerImgEmblem =
                    await session.Query(new HaloSharp.Query.Profile.GetEmblemImage().ForPlayer(Gamertag));

                // Grab gamers current avatar
                var playerImgSpartanImage =
                    await session.Query(new HaloSharp.Query.Profile.GetSpartanImage().ForPlayer(Gamertag));

                // Calculate total Kill / Death
                float totalKillsDeath = (float) totalKills/(float) totalDeath;

                // Calculate total Kill+Assist / Death
                float totalKillsWithAssistsDeath = ((float) totalKills + (float) totalAssists)/(float) totalDeath;

                // Calculate TotalShot Accuracy
                float playersTotalAccuracy = 100*((float) totalShotsLanded/(float) totalShotsFired);

                TopMedals = warzoneServiceRecord.Results[0].Result.WarzoneStat.MedalAwards;
                TopMedals.AddRange(arenaServiceRecord.Results[0].Result.ArenaStats.MedalAwards.ToList());
                TopMedals=TopMedals.OrderByDescending(o => o.Count).ToList();


                //UI-Updates
                UiSetPlayerEmblem(playerImgEmblem.Image, pictureBox1);
                UiSetPlayerSpartanImage(playerImgSpartanImage.Image, pictureBox2);
                UiUpdateLabel(Resources.prefixSrWithSpace + currentSpartanRank, l_rank_);
                UiUpdateLabel(Gamertag, l_gamertag_, Color.White);
                UiUpdateLabel(Resources.prefixTotalTimePlayedWithNewline + totalPlayTimeString, l_time_played);
                UiUpdateLabel("Kills: \t" + totalKills, l_totalKills);
                UiUpdateLabel("Deaths: \t" + totalDeath, l_totalDeaths);
                UiUpdateLabel("Assists: \t" + totalAssists, l_totalAssists);
                UiUpdateLabel("K/D: \t" + totalKillsDeath.ToString("0.00"), l_killsDeath);
                UiUpdateLabel("K+A/D: \t" + totalKillsWithAssistsDeath.ToString("0.00"), l_killsAssistsDeath);
                UiUpdateLabel("Headshots: \t" + totalHeadshots, l_headshots);
                UiUpdateLabel("Assassinations: \t" + totalAssassinations, l_assassinations);
                UiUpdateLabel("Total Match-Count: \t" + totalGames, l_totalMatchesCount);
                UiUpdateLabel("Total Matches Won: \t" + totalWon, l_totalMatchesWon, Color.DarkGreen);
                UiUpdateLabel("Total Matches Lost: \t" + totalLost, l_totalMatchesLost, Color.Red);
                UiUpdateLabel("Total Shots Fired: \t" + totalShotsFired.ToString("#,###"), l_totalShotsFired);
                UiUpdateLabel("Total Shots Landed: \t" + totalShotsLanded.ToString("#,###"), l_totalShotsLanded);
                UiUpdateLabel("Shot Accuracy: \t" + playersTotalAccuracy.ToString("0.00") + " %", l_totalShotsAccuracy);
                

                var bitmap2 = Tools.BitmapFromUrl(Tools.GetMedalFromMedalList(Medals, TopMedals[0].MedalId).SpriteLocation.SpriteSheetUri);
                for (var max = 0; max < 10; max++)
                {
                    var medalx = Tools.GetMedalFromMedalList(Medals, TopMedals[max].MedalId);
                    var cloneRect = Tools.MedalSpriteRectangle(medalx);
                    var cloneBitmap = Tools.GetSpriteFromImage(bitmap2, cloneRect);
                    Invoke((MethodInvoker)delegate { TopMedalPicBoxes[max].Image = Tools.ScaleImage(cloneBitmap, 64, 64); });
                    UiUpdateLabel(Medals.First(item => item.Id == TopMedals[max].MedalId).Name + "\n[ " + TopMedals[max].Count + " ]", TopMedalLabels[max]);
                }
                Invoke((MethodInvoker)delegate { circularProgressBar1.Caption = Resources.prefixSrWithSpace + "\n" + percentSpartanRankCurrent.ToString("0.00") + " %"; circularProgressBar1.Value = Convert.ToInt32(percentSpartanRankCurrent); });
                
            }
            UpdateWarzone();
        }

        public async void UpdateWarzone()
        {

            var client = new HaloClient(DevAcc);
            using (var session = client.StartSession())
            {
                var totalPlayTime = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalTimePlayed;
                
                // Parse the total played time to a custom string
                var totalPlayTimeString = $"{totalPlayTime.Days}D {totalPlayTime.Hours}Hr {totalPlayTime.Minutes}Min";

                // Calculate the "Warzone" total kills
                var totalKills = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalKills;

                // Calculate the "Warzone" total deaths
                var totalDeath = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalDeaths;

                // Calculate the "Warzone" total assists
                var totalAssists = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalAssists;

                // Calculate the "Warzone" total headshots
                var totalHeadshots = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalHeadshots;

                // Calculate the "Warzone" total TotalShots
                var totalShotsFired = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalShotsFired;

                // Calculate the "Warzone" total headshots
                var totalShotsLanded = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalShotsLanded;

                // Calculate the "Warzone" total assassinations
                var totalAssassinations = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalAssassinations;

                // Calculate the "Warzone" total game-counts
                var totalGames = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesCompleted;

                // Calculate the "Warzone" total wins
                var totalWon = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesWon;

                // Calculate the "Warzone" total losts
                var totalLost = warzoneServiceRecord.Results[0].Result.WarzoneStat.TotalGamesLost;

                // Calculate total Kill / Death
                float totalKillsDeath = (float)totalKills / (float)totalDeath;

                // Calculate total Kill+Assist / Death
                float totalKillsWithAssistsDeath = ((float)totalKills + (float)totalAssists) / (float)totalDeath;

                // Calculate TotalShot Accuracy
                float playersTotalAccuracy = 100 * ((float)totalShotsLanded / (float)totalShotsFired);

                TopMedals = warzoneServiceRecord.Results[0].Result.WarzoneStat.MedalAwards;
                TopMedals = TopMedals.OrderByDescending(o => o.Count).ToList();
                var bitmap2 = Tools.BitmapFromUrl(Tools.GetMedalFromMedalList(Medals, TopMedals[0].MedalId).SpriteLocation.SpriteSheetUri);

                for (var max = 0; max < 5; max++)
                {
                    var medalx = Tools.GetMedalFromMedalList(Medals, TopMedals[max].MedalId);
                    var cloneRect = Tools.MedalSpriteRectangle(medalx);
                    var cloneBitmap = Tools.GetSpriteFromImage(bitmap2, cloneRect);
                    Invoke((MethodInvoker)delegate { WarzoneTopMedalPicBoxes[max].Image = Tools.ScaleImage(cloneBitmap, 64, 64); });
                    UiUpdateLabel(Medals.First(item => item.Id == TopMedals[max].MedalId).Name + "\n[ " + TopMedals[max].Count + " ]", WarzoneTopMedalLabels[max]);
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

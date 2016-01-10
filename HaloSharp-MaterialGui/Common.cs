// ***********************************************************************
// Assembly         : HaloApiTest
// Author           : Kevin Kleinjung
// Created          : 01-09-2016
//
// Last Modified By : Kevin Kleinjung
// Last Modified On : 01-09-2016
// ***********************************************************************
// <copyright file="Common.cs" company="Fresh-Dev">
//     Copyright © Kevin Kleinjung 2016
// </copyright>
// <summary>Mainform's common variables, objects and methods</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HaloSharp;
using HaloSharp.Model;
using HaloSharp.Model.Metadata;
using HaloSharp.Model.Stats.Common;
using HaloSharp.Model.Stats.Lifetime.Common;

namespace MaterialHaloSharp
{
    /// <summary>
    /// Class Mainform.
    /// </summary>
    public partial class Mainform
    {
        /// <summary>
        /// The http://developer.haloapi.com Api-Key
        /// </summary>
        public string Apikey = "";

        /// <summary>
        /// The gamertag
        /// </summary>
        private string Gamertag = "";

        /// <summary>
        /// The meta data loaded
        /// </summary>
        public bool MetaDataLoaded = false;

        /// <summary>
        /// The HaloApi-Connector Settings
        /// </summary>
        private readonly Product DevAcc = new Product { SubscriptionKey = Properties.Settings.Default.ApiKey, RateLimit = new RateLimit { RequestCount = 10, Timeout = Timeout.InfiniteTimeSpan, TimspSpan = new TimeSpan(0, 0, 0, 10) } };

        

        //private static HaloSharp.HaloSession session = new HaloSession(DevAcc);


        /// <summary>
        /// The spartan ranks
        /// </summary>
        public List<SpartanRank> SpartanRanks = null;

        /// <summary>
        /// The maps
        /// </summary>
        public List<Map> Maps = null;

        /// <summary>
        /// The commendations
        /// </summary>
        public List<Commendation> Commendations = null;

        /// <summary>
        /// The medals
        /// </summary>
        public List<Medal> Medals = null;

        /// <summary>
        /// The medals
        /// </summary>
        public List<MedalAward> TopMedals = null;

        /// <summary>
        /// The Weapons
        /// </summary>
        public List<Weapon> Weapons = null;

        /// <summary>
        /// The medals
        /// </summary>
        public List<HaloSharp.Model.Stats.Common.WeaponStat> WarzoneTopWeapons = null;

        /// <summary>
        /// The top medal labels
        /// </summary>
        public List<Label> TopMedalLabels = new List<Label>();

        /// <summary>
        /// The top medal pic boxes
        /// </summary>
        public List<PictureBox> TopMedalPicBoxes = new List<PictureBox>();

        /// <summary>
        /// The warzone top medal pic boxes
        /// </summary>
        public List<PictureBox> WarzoneTopMedalPicBoxes = new List<PictureBox>();
        
        /// <summary>
        /// The warzone top medal labels
        /// </summary>
        public List<Label> WarzoneTopMedalLabels = new List<Label>();


        /// <summary>
        /// The warzone top weapons pic boxes
        /// </summary>
        public List<PictureBox> WarzoneTopWeaponsPicBoxes = new List<PictureBox>();

        /// <summary>
        /// The warzone top weapons labels
        /// </summary>
        public List<Label> WarzoneTopWeaponsLabels = new List<Label>();

        

        /// <summary>
        /// The base result
        /// </summary>
        public BaseResult BaseResult = null;

        /// <summary>
        /// UI: Set player's emblem to PictureBox.
        /// </summary>
        /// <param name="playerEmblemImage">The player emblem image.</param>
        /// <param name="targetPictureBox">The target picture box.</param>
        public void UiSetPlayerEmblem(Image playerEmblemImage, PictureBox targetPictureBox)
        {
            var scaledImage = Tools.ScaleImage(playerEmblemImage, playerEmblemImage.Width / 4, playerEmblemImage.Height / 4);
            Invoke((MethodInvoker)delegate
            {
                targetPictureBox.Image = scaledImage;
                targetPictureBox.Height = playerEmblemImage.Height / 2;
                targetPictureBox.Width = playerEmblemImage.Width / 2;
            });
        }

        /// <summary>
        /// UI: Set player's SpartanImage to PictureBox.
        /// </summary>
        /// <param name="img">The img.</param>
        /// <param name="targetPictureBox">The target picture box.</param>
        public void UiSetPlayerSpartanImage(Image img, PictureBox targetPictureBox)
        {
            var newImg = Tools.ScaleImage(img, img.Width, img.Height);
            Invoke((MethodInvoker)delegate
            {
                targetPictureBox.Image = newImg;
                targetPictureBox.Height = img.Height;
                targetPictureBox.Width = img.Width;
            });
        }

        /// <summary>
        /// UI: Update specified Label.
        /// </summary>
        /// <param name="labelText">The label text.</param>
        /// <param name="labelControl">The label control.</param>
        public void UiUpdateLabel(string labelText, Label labelControl)
        {
            Invoke((MethodInvoker)delegate
            {
                labelControl.Text = labelText;
            });
        }

        /// <summary>
        /// UI: Update specified Label.
        /// </summary>
        /// <param name="labelText">The label text.</param>
        /// <param name="labelControl">The label control.</param>
        /// <param name="foreColor">Color of the text.</param>
        public void UiUpdateLabel(string labelText, Label labelControl, Color foreColor)
        {
            Invoke((MethodInvoker)delegate
            {
                labelControl.Text = labelText;
                labelControl.ForeColor = foreColor;
            });
        }

        /// <summary>
        /// UI: Update specified Label.
        /// </summary>
        /// <param name="labelText">The label text.</param>
        /// <param name="labelControl">The label control.</param>
        /// <param name="labelFont">The label font.</param>
        public void UiUpdateLabel(string labelText, Label labelControl, Font labelFont)
        {
            Invoke((MethodInvoker)delegate
            {
                labelControl.Text = labelText;
                labelControl.Font = labelFont;
            });
        }

        /// <summary>
        /// Get Spartans current rank exp. percentage by giving the current total xp.
        /// </summary>
        /// <param name="currentSpartanXp">The current spartan xp.</param>
        /// <returns>System.Double.</returns>
        public double SpartanRankGetPercentage(int currentSpartanXp)
        {
            int currentSpartanRank=0;
            int[] nextSpartanRank = { 0 };
            foreach (var sr in SpartanRanks.Where(
                            sr => sr.StartXp > currentSpartanXp &&
                            nextSpartanRank[0] == 0)
                    )
            {
                nextSpartanRank[0] = sr.Id;
                currentSpartanRank = sr.Id;
            }
            

            var lastTargetXp = SpartanRanks[nextSpartanRank[0] - 1].StartXp;
            var targetXp = SpartanRanks[nextSpartanRank[0]].StartXp;
            var levelProgressTargetXp = targetXp - lastTargetXp;
            var levelProgressXp = lastTargetXp - currentSpartanXp;

            

            string output = "Current Rank: "+currentSpartanRank+"\n\tCurrentXP:\t"+currentSpartanXp+"\n\tLvL-Target-XP:\t"+lastTargetXp+"\n\t";

            MessageBox.Show(output);

            double percentage = double.Parse(lastTargetXp.ToString()) / double.Parse(levelProgressXp.ToString());

            return percentage;
        }
        
    }
}

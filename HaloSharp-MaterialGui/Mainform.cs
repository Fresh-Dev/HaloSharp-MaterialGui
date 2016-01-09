// ***********************************************************************
// Assembly         : HaloApiTest
// Author           : Kevin Kleinjung
// Created          : 01-02-2016
//
// Last Modified By : Kevin Kleinjung
// Last Modified On : 01-09-2016
// ***********************************************************************
// <copyright file="Mainform.cs" company="Fresh-Dev">
//     Copyright © Kevin Kleinjung 2016
// </copyright>
// <summary>Mainform Init-File</summary>
// ***********************************************************************
using System;
using System.Drawing.Text;
using System.Windows.Forms;
using MaterialHaloSharp;
using System.Linq;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialHaloSharp
{
   

    /// <summary>
        /// Class Mainform.
        /// </summary>
        public partial class Mainform : MaterialForm
        {

        /// <summary>
        /// Initializes a new instance of the <see cref="Mainform" /> class.
        /// </summary>
        public Mainform()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey400, Primary.BlueGrey50, Accent.Red200, TextShade.WHITE);
            

            #region Fill <Control> Lists for Overview Tab
            //Fill LabelCollection for Overview-Tab's TopMedal-Labels
            TopMedalLabels.Add(l_med_1);
            TopMedalLabels.Add(l_med_2);
            TopMedalLabels.Add(l_med_3);
            TopMedalLabels.Add(l_med_4);
            TopMedalLabels.Add(l_med_5);
            TopMedalLabels.Add(l_med_6);
            TopMedalLabels.Add(l_med_7);
            TopMedalLabels.Add(l_med_8);
            TopMedalLabels.Add(l_med_9);
            TopMedalLabels.Add(l_med_10);

            //Fill PictureBoxCollection for Overview-Tab's TopMedal-PictureBoxes
            TopMedalPicBoxes.Add(pb_medal1);
            TopMedalPicBoxes.Add(pb_medal2);
            TopMedalPicBoxes.Add(pb_medal3);
            TopMedalPicBoxes.Add(pb_medal4);
            TopMedalPicBoxes.Add(pb_medal5);
            TopMedalPicBoxes.Add(pb_medal6);
            TopMedalPicBoxes.Add(pb_medal7);
            TopMedalPicBoxes.Add(pb_medal8);
            TopMedalPicBoxes.Add(pb_medal9);
            TopMedalPicBoxes.Add(pb_medal10);
            #endregion

            #region Fill <Control> Lists for Warzone Tab
            //Fill LabelCollection for Warzones-Tab's TopMedal-Labels
            WarzoneTopMedalLabels.Add(l_warzoneTopMedals_1);
            WarzoneTopMedalLabels.Add(l_warzoneTopMedals_2);
            WarzoneTopMedalLabels.Add(l_warzoneTopMedals_3);
            WarzoneTopMedalLabels.Add(l_warzoneTopMedals_4);
            WarzoneTopMedalLabels.Add(l_warzoneTopMedals_5);

            //Fill LabelCollection for Warzones-Tab's TopWeapons-Labels
            WarzoneTopMedalLabels.Add(l_warzoneTopWeapons_1);
            WarzoneTopMedalLabels.Add(l_warzoneTopWeapons_2);
            WarzoneTopMedalLabels.Add(l_warzoneTopWeapons_3);
            WarzoneTopMedalLabels.Add(l_warzoneTopWeapons_4);
            WarzoneTopMedalLabels.Add(l_warzoneTopWeapons_5);


            //Fill PictureBoxCollection for Warzones-Tab's TopMedal-Labels
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopMedals_1);
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopMedals_2);
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopMedals_3);
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopMedals_4);
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopMedals_5);

            //Fill PictureBoxCollection for Warzones-Tab's TopWeapons-Labels
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopWeapons_1);
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopWeapons_2);
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopWeapons_3);
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopWeapons_4);
            WarzoneTopMedalPicBoxes.Add(pbWarzoneTopWeapons_5);
            #endregion

            GetGlobalMetaData();

            
            
        }
    }
}



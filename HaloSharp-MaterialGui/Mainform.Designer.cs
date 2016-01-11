using MaterialHaloSharp.Special_Controls;
using MaterialSkin.Controls;

namespace MaterialHaloSharp
{
    public partial class Mainform : MaterialForm
    {

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.l_med_10 = new System.Windows.Forms.Label();
            this.l_med_9 = new System.Windows.Forms.Label();
            this.l_med_8 = new System.Windows.Forms.Label();
            this.l_med_7 = new System.Windows.Forms.Label();
            this.l_med_6 = new System.Windows.Forms.Label();
            this.l_med_5 = new System.Windows.Forms.Label();
            this.l_med_4 = new System.Windows.Forms.Label();
            this.l_med_3 = new System.Windows.Forms.Label();
            this.l_med_2 = new System.Windows.Forms.Label();
            this.l_med_1 = new System.Windows.Forms.Label();
            this.pb_medal10 = new System.Windows.Forms.PictureBox();
            this.pb_medal9 = new System.Windows.Forms.PictureBox();
            this.pb_medal8 = new System.Windows.Forms.PictureBox();
            this.pb_medal7 = new System.Windows.Forms.PictureBox();
            this.pb_medal6 = new System.Windows.Forms.PictureBox();
            this.pb_medal5 = new System.Windows.Forms.PictureBox();
            this.pb_medal4 = new System.Windows.Forms.PictureBox();
            this.pb_medal3 = new System.Windows.Forms.PictureBox();
            this.pb_medal2 = new System.Windows.Forms.PictureBox();
            this.pb_medal1 = new System.Windows.Forms.PictureBox();
            this.l_totalShotsAccuracy = new System.Windows.Forms.Label();
            this.l_totalShotsLanded = new System.Windows.Forms.Label();
            this.l_totalShotsFired = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.l_totalMatchesLost = new System.Windows.Forms.Label();
            this.l_totalMatchesWon = new System.Windows.Forms.Label();
            this.l_totalMatchesCount = new System.Windows.Forms.Label();
            this.l_assassinations = new System.Windows.Forms.Label();
            this.l_headshots = new System.Windows.Forms.Label();
            this.l_killsAssistsDeath = new System.Windows.Forms.Label();
            this.l_killsDeath = new System.Windows.Forms.Label();
            this.l_totalAssists = new System.Windows.Forms.Label();
            this.l_totalDeaths = new System.Windows.Forms.Label();
            this.l_totalKills = new System.Windows.Forms.Label();
            this.l_time_played = new System.Windows.Forms.Label();
            this.l_rank_ = new System.Windows.Forms.Label();
            this.l_gamertag_ = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.l_warzoneTopWeapons_5 = new System.Windows.Forms.Label();
            this.l_warzoneTopWeapons_4 = new System.Windows.Forms.Label();
            this.l_warzoneTopWeapons_3 = new System.Windows.Forms.Label();
            this.l_warzoneTopWeapons_2 = new System.Windows.Forms.Label();
            this.l_warzoneTopWeapons_1 = new System.Windows.Forms.Label();
            this.l_warzoneTopMedals_5 = new System.Windows.Forms.Label();
            this.l_warzoneTopMedals_4 = new System.Windows.Forms.Label();
            this.l_warzoneTopMedals_3 = new System.Windows.Forms.Label();
            this.l_warzoneTopMedals_2 = new System.Windows.Forms.Label();
            this.l_warzoneTopMedals_1 = new System.Windows.Forms.Label();
            this.pbWarzoneTopWeapons_5 = new System.Windows.Forms.PictureBox();
            this.pbWarzoneTopWeapons_4 = new System.Windows.Forms.PictureBox();
            this.pbWarzoneTopWeapons_3 = new System.Windows.Forms.PictureBox();
            this.pbWarzoneTopWeapons_2 = new System.Windows.Forms.PictureBox();
            this.pbWarzoneTopWeapons_1 = new System.Windows.Forms.PictureBox();
            this.pbWarzoneTopMedals_5 = new System.Windows.Forms.PictureBox();
            this.pbWarzoneTopMedals_4 = new System.Windows.Forms.PictureBox();
            this.pbWarzoneTopMedals_3 = new System.Windows.Forms.PictureBox();
            this.pbWarzoneTopMedals_2 = new System.Windows.Forms.PictureBox();
            this.pbWarzoneTopMedals_1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.asasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_h_medals = new MaterialHaloSharp.Special_Controls.fxLabel();
            this.circularProgressBar1 = new MaterialHaloSharp.Special_Controls.CircularProgressBar();
            this.fxLabel3 = new MaterialHaloSharp.Special_Controls.fxLabel();
            this.circularProgressBar2 = new MaterialHaloSharp.Special_Controls.CircularProgressBar();
            this.fxLabel2 = new MaterialHaloSharp.Special_Controls.fxLabel();
            this.fxLabel1 = new MaterialHaloSharp.Special_Controls.fxLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_1)).BeginInit();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 59);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(984, 56);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 121);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(984, 517);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.l_med_10);
            this.tabPage1.Controls.Add(this.l_med_9);
            this.tabPage1.Controls.Add(this.l_med_8);
            this.tabPage1.Controls.Add(this.l_med_7);
            this.tabPage1.Controls.Add(this.l_med_6);
            this.tabPage1.Controls.Add(this.l_med_5);
            this.tabPage1.Controls.Add(this.l_med_4);
            this.tabPage1.Controls.Add(this.l_med_3);
            this.tabPage1.Controls.Add(this.l_med_2);
            this.tabPage1.Controls.Add(this.l_med_1);
            this.tabPage1.Controls.Add(this.pb_medal10);
            this.tabPage1.Controls.Add(this.pb_medal9);
            this.tabPage1.Controls.Add(this.pb_medal8);
            this.tabPage1.Controls.Add(this.pb_medal7);
            this.tabPage1.Controls.Add(this.pb_medal6);
            this.tabPage1.Controls.Add(this.pb_medal5);
            this.tabPage1.Controls.Add(this.pb_medal4);
            this.tabPage1.Controls.Add(this.pb_medal3);
            this.tabPage1.Controls.Add(this.pb_medal2);
            this.tabPage1.Controls.Add(this.pb_medal1);
            this.tabPage1.Controls.Add(this.l_h_medals);
            this.tabPage1.Controls.Add(this.l_totalShotsAccuracy);
            this.tabPage1.Controls.Add(this.l_totalShotsLanded);
            this.tabPage1.Controls.Add(this.l_totalShotsFired);
            this.tabPage1.Controls.Add(this.materialDivider1);
            this.tabPage1.Controls.Add(this.l_totalMatchesLost);
            this.tabPage1.Controls.Add(this.l_totalMatchesWon);
            this.tabPage1.Controls.Add(this.l_totalMatchesCount);
            this.tabPage1.Controls.Add(this.l_assassinations);
            this.tabPage1.Controls.Add(this.l_headshots);
            this.tabPage1.Controls.Add(this.l_killsAssistsDeath);
            this.tabPage1.Controls.Add(this.l_killsDeath);
            this.tabPage1.Controls.Add(this.l_totalAssists);
            this.tabPage1.Controls.Add(this.l_totalDeaths);
            this.tabPage1.Controls.Add(this.l_totalKills);
            this.tabPage1.Controls.Add(this.l_time_played);
            this.tabPage1.Controls.Add(this.l_rank_);
            this.tabPage1.Controls.Add(this.l_gamertag_);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.circularProgressBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spartan-Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // l_med_10
            // 
            this.l_med_10.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_10.ForeColor = System.Drawing.Color.Gray;
            this.l_med_10.Location = new System.Drawing.Point(905, 391);
            this.l_med_10.Name = "l_med_10";
            this.l_med_10.Size = new System.Drawing.Size(64, 90);
            this.l_med_10.TabIndex = 51;
            this.l_med_10.Text = "-----";
            this.l_med_10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_10.UseCompatibleTextRendering = true;
            // 
            // l_med_9
            // 
            this.l_med_9.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_9.ForeColor = System.Drawing.Color.Gray;
            this.l_med_9.Location = new System.Drawing.Point(835, 391);
            this.l_med_9.Name = "l_med_9";
            this.l_med_9.Size = new System.Drawing.Size(64, 90);
            this.l_med_9.TabIndex = 50;
            this.l_med_9.Text = "-----";
            this.l_med_9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_9.UseCompatibleTextRendering = true;
            // 
            // l_med_8
            // 
            this.l_med_8.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_8.ForeColor = System.Drawing.Color.Gray;
            this.l_med_8.Location = new System.Drawing.Point(765, 391);
            this.l_med_8.Name = "l_med_8";
            this.l_med_8.Size = new System.Drawing.Size(64, 90);
            this.l_med_8.TabIndex = 49;
            this.l_med_8.Text = "-----";
            this.l_med_8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_8.UseCompatibleTextRendering = true;
            // 
            // l_med_7
            // 
            this.l_med_7.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_7.ForeColor = System.Drawing.Color.Gray;
            this.l_med_7.Location = new System.Drawing.Point(695, 391);
            this.l_med_7.Name = "l_med_7";
            this.l_med_7.Size = new System.Drawing.Size(64, 90);
            this.l_med_7.TabIndex = 48;
            this.l_med_7.Text = "-----";
            this.l_med_7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_7.UseCompatibleTextRendering = true;
            // 
            // l_med_6
            // 
            this.l_med_6.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_6.ForeColor = System.Drawing.Color.Gray;
            this.l_med_6.Location = new System.Drawing.Point(625, 391);
            this.l_med_6.Name = "l_med_6";
            this.l_med_6.Size = new System.Drawing.Size(64, 90);
            this.l_med_6.TabIndex = 47;
            this.l_med_6.Text = "-----";
            this.l_med_6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_6.UseCompatibleTextRendering = true;
            // 
            // l_med_5
            // 
            this.l_med_5.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_5.ForeColor = System.Drawing.Color.Gray;
            this.l_med_5.Location = new System.Drawing.Point(555, 391);
            this.l_med_5.Name = "l_med_5";
            this.l_med_5.Size = new System.Drawing.Size(64, 90);
            this.l_med_5.TabIndex = 46;
            this.l_med_5.Text = "-----";
            this.l_med_5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_5.UseCompatibleTextRendering = true;
            // 
            // l_med_4
            // 
            this.l_med_4.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_4.ForeColor = System.Drawing.Color.Gray;
            this.l_med_4.Location = new System.Drawing.Point(485, 391);
            this.l_med_4.Name = "l_med_4";
            this.l_med_4.Size = new System.Drawing.Size(64, 90);
            this.l_med_4.TabIndex = 45;
            this.l_med_4.Text = "-----";
            this.l_med_4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_4.UseCompatibleTextRendering = true;
            // 
            // l_med_3
            // 
            this.l_med_3.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_3.ForeColor = System.Drawing.Color.Gray;
            this.l_med_3.Location = new System.Drawing.Point(415, 391);
            this.l_med_3.Name = "l_med_3";
            this.l_med_3.Size = new System.Drawing.Size(64, 90);
            this.l_med_3.TabIndex = 44;
            this.l_med_3.Text = "-----";
            this.l_med_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_3.UseCompatibleTextRendering = true;
            // 
            // l_med_2
            // 
            this.l_med_2.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_2.ForeColor = System.Drawing.Color.Gray;
            this.l_med_2.Location = new System.Drawing.Point(345, 391);
            this.l_med_2.Name = "l_med_2";
            this.l_med_2.Size = new System.Drawing.Size(60, 90);
            this.l_med_2.TabIndex = 43;
            this.l_med_2.Text = "-----";
            this.l_med_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_2.UseCompatibleTextRendering = true;
            // 
            // l_med_1
            // 
            this.l_med_1.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_med_1.ForeColor = System.Drawing.Color.Gray;
            this.l_med_1.Location = new System.Drawing.Point(275, 391);
            this.l_med_1.Name = "l_med_1";
            this.l_med_1.Size = new System.Drawing.Size(61, 90);
            this.l_med_1.TabIndex = 42;
            this.l_med_1.Text = "-----";
            this.l_med_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_med_1.UseCompatibleTextRendering = true;
            // 
            // pb_medal10
            // 
            this.pb_medal10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal10.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal10.Image")));
            this.pb_medal10.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal10.InitialImage")));
            this.pb_medal10.Location = new System.Drawing.Point(905, 324);
            this.pb_medal10.Name = "pb_medal10";
            this.pb_medal10.Size = new System.Drawing.Size(64, 64);
            this.pb_medal10.TabIndex = 41;
            this.pb_medal10.TabStop = false;
            // 
            // pb_medal9
            // 
            this.pb_medal9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal9.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal9.Image")));
            this.pb_medal9.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal9.InitialImage")));
            this.pb_medal9.Location = new System.Drawing.Point(835, 324);
            this.pb_medal9.Name = "pb_medal9";
            this.pb_medal9.Size = new System.Drawing.Size(64, 64);
            this.pb_medal9.TabIndex = 40;
            this.pb_medal9.TabStop = false;
            // 
            // pb_medal8
            // 
            this.pb_medal8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal8.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal8.Image")));
            this.pb_medal8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal8.InitialImage")));
            this.pb_medal8.Location = new System.Drawing.Point(765, 324);
            this.pb_medal8.Name = "pb_medal8";
            this.pb_medal8.Size = new System.Drawing.Size(64, 64);
            this.pb_medal8.TabIndex = 39;
            this.pb_medal8.TabStop = false;
            // 
            // pb_medal7
            // 
            this.pb_medal7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal7.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal7.Image")));
            this.pb_medal7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal7.InitialImage")));
            this.pb_medal7.Location = new System.Drawing.Point(695, 324);
            this.pb_medal7.Name = "pb_medal7";
            this.pb_medal7.Size = new System.Drawing.Size(64, 64);
            this.pb_medal7.TabIndex = 38;
            this.pb_medal7.TabStop = false;
            // 
            // pb_medal6
            // 
            this.pb_medal6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal6.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal6.Image")));
            this.pb_medal6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal6.InitialImage")));
            this.pb_medal6.Location = new System.Drawing.Point(625, 324);
            this.pb_medal6.Name = "pb_medal6";
            this.pb_medal6.Size = new System.Drawing.Size(64, 64);
            this.pb_medal6.TabIndex = 37;
            this.pb_medal6.TabStop = false;
            // 
            // pb_medal5
            // 
            this.pb_medal5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal5.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal5.Image")));
            this.pb_medal5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal5.InitialImage")));
            this.pb_medal5.Location = new System.Drawing.Point(555, 324);
            this.pb_medal5.Name = "pb_medal5";
            this.pb_medal5.Size = new System.Drawing.Size(64, 64);
            this.pb_medal5.TabIndex = 36;
            this.pb_medal5.TabStop = false;
            // 
            // pb_medal4
            // 
            this.pb_medal4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal4.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal4.Image")));
            this.pb_medal4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal4.InitialImage")));
            this.pb_medal4.Location = new System.Drawing.Point(485, 324);
            this.pb_medal4.Name = "pb_medal4";
            this.pb_medal4.Size = new System.Drawing.Size(64, 64);
            this.pb_medal4.TabIndex = 35;
            this.pb_medal4.TabStop = false;
            // 
            // pb_medal3
            // 
            this.pb_medal3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal3.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal3.Image")));
            this.pb_medal3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal3.InitialImage")));
            this.pb_medal3.Location = new System.Drawing.Point(415, 324);
            this.pb_medal3.Name = "pb_medal3";
            this.pb_medal3.Size = new System.Drawing.Size(64, 64);
            this.pb_medal3.TabIndex = 34;
            this.pb_medal3.TabStop = false;
            // 
            // pb_medal2
            // 
            this.pb_medal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal2.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal2.Image")));
            this.pb_medal2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal2.InitialImage")));
            this.pb_medal2.Location = new System.Drawing.Point(345, 324);
            this.pb_medal2.Name = "pb_medal2";
            this.pb_medal2.Size = new System.Drawing.Size(64, 64);
            this.pb_medal2.TabIndex = 33;
            this.pb_medal2.TabStop = false;
            // 
            // pb_medal1
            // 
            this.pb_medal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_medal1.Image = ((System.Drawing.Image)(resources.GetObject("pb_medal1.Image")));
            this.pb_medal1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_medal1.InitialImage")));
            this.pb_medal1.Location = new System.Drawing.Point(275, 324);
            this.pb_medal1.Name = "pb_medal1";
            this.pb_medal1.Size = new System.Drawing.Size(64, 64);
            this.pb_medal1.TabIndex = 32;
            this.pb_medal1.TabStop = false;
            // 
            // l_totalShotsAccuracy
            // 
            this.l_totalShotsAccuracy.AutoSize = true;
            this.l_totalShotsAccuracy.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_totalShotsAccuracy.ForeColor = System.Drawing.Color.Gray;
            this.l_totalShotsAccuracy.Location = new System.Drawing.Point(642, 234);
            this.l_totalShotsAccuracy.Name = "l_totalShotsAccuracy";
            this.l_totalShotsAccuracy.Size = new System.Drawing.Size(33, 28);
            this.l_totalShotsAccuracy.TabIndex = 30;
            this.l_totalShotsAccuracy.Text = "-----";
            this.l_totalShotsAccuracy.UseCompatibleTextRendering = true;
            // 
            // l_totalShotsLanded
            // 
            this.l_totalShotsLanded.AutoSize = true;
            this.l_totalShotsLanded.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_totalShotsLanded.ForeColor = System.Drawing.Color.Gray;
            this.l_totalShotsLanded.Location = new System.Drawing.Point(642, 210);
            this.l_totalShotsLanded.Name = "l_totalShotsLanded";
            this.l_totalShotsLanded.Size = new System.Drawing.Size(33, 28);
            this.l_totalShotsLanded.TabIndex = 29;
            this.l_totalShotsLanded.Text = "-----";
            this.l_totalShotsLanded.UseCompatibleTextRendering = true;
            // 
            // l_totalShotsFired
            // 
            this.l_totalShotsFired.AutoSize = true;
            this.l_totalShotsFired.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_totalShotsFired.ForeColor = System.Drawing.Color.Gray;
            this.l_totalShotsFired.Location = new System.Drawing.Point(642, 186);
            this.l_totalShotsFired.Name = "l_totalShotsFired";
            this.l_totalShotsFired.Size = new System.Drawing.Size(33, 28);
            this.l_totalShotsFired.TabIndex = 28;
            this.l_totalShotsFired.Text = "-----";
            this.l_totalShotsFired.UseCompatibleTextRendering = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(268, 283);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(701, 5);
            this.materialDivider1.TabIndex = 27;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // l_totalMatchesLost
            // 
            this.l_totalMatchesLost.AutoSize = true;
            this.l_totalMatchesLost.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_totalMatchesLost.ForeColor = System.Drawing.Color.Gray;
            this.l_totalMatchesLost.Location = new System.Drawing.Point(349, 234);
            this.l_totalMatchesLost.Name = "l_totalMatchesLost";
            this.l_totalMatchesLost.Size = new System.Drawing.Size(33, 28);
            this.l_totalMatchesLost.TabIndex = 18;
            this.l_totalMatchesLost.Text = "-----";
            this.l_totalMatchesLost.UseCompatibleTextRendering = true;
            // 
            // l_totalMatchesWon
            // 
            this.l_totalMatchesWon.AutoSize = true;
            this.l_totalMatchesWon.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_totalMatchesWon.ForeColor = System.Drawing.Color.Gray;
            this.l_totalMatchesWon.Location = new System.Drawing.Point(349, 210);
            this.l_totalMatchesWon.Name = "l_totalMatchesWon";
            this.l_totalMatchesWon.Size = new System.Drawing.Size(33, 28);
            this.l_totalMatchesWon.TabIndex = 17;
            this.l_totalMatchesWon.Text = "-----";
            this.l_totalMatchesWon.UseCompatibleTextRendering = true;
            // 
            // l_totalMatchesCount
            // 
            this.l_totalMatchesCount.AutoSize = true;
            this.l_totalMatchesCount.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_totalMatchesCount.ForeColor = System.Drawing.Color.Gray;
            this.l_totalMatchesCount.Location = new System.Drawing.Point(349, 186);
            this.l_totalMatchesCount.Name = "l_totalMatchesCount";
            this.l_totalMatchesCount.Size = new System.Drawing.Size(33, 28);
            this.l_totalMatchesCount.TabIndex = 16;
            this.l_totalMatchesCount.Text = "-----";
            this.l_totalMatchesCount.UseCompatibleTextRendering = true;
            // 
            // l_assassinations
            // 
            this.l_assassinations.AutoSize = true;
            this.l_assassinations.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_assassinations.ForeColor = System.Drawing.Color.Gray;
            this.l_assassinations.Location = new System.Drawing.Point(526, 149);
            this.l_assassinations.Name = "l_assassinations";
            this.l_assassinations.Size = new System.Drawing.Size(33, 28);
            this.l_assassinations.TabIndex = 15;
            this.l_assassinations.Text = "-----";
            this.l_assassinations.UseCompatibleTextRendering = true;
            // 
            // l_headshots
            // 
            this.l_headshots.AutoSize = true;
            this.l_headshots.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_headshots.ForeColor = System.Drawing.Color.Gray;
            this.l_headshots.Location = new System.Drawing.Point(526, 125);
            this.l_headshots.Name = "l_headshots";
            this.l_headshots.Size = new System.Drawing.Size(33, 28);
            this.l_headshots.TabIndex = 14;
            this.l_headshots.Text = "-----";
            this.l_headshots.UseCompatibleTextRendering = true;
            // 
            // l_killsAssistsDeath
            // 
            this.l_killsAssistsDeath.AutoSize = true;
            this.l_killsAssistsDeath.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_killsAssistsDeath.ForeColor = System.Drawing.Color.Gray;
            this.l_killsAssistsDeath.Location = new System.Drawing.Point(819, 81);
            this.l_killsAssistsDeath.Name = "l_killsAssistsDeath";
            this.l_killsAssistsDeath.Size = new System.Drawing.Size(33, 28);
            this.l_killsAssistsDeath.TabIndex = 13;
            this.l_killsAssistsDeath.Text = "-----";
            this.l_killsAssistsDeath.UseCompatibleTextRendering = true;
            // 
            // l_killsDeath
            // 
            this.l_killsDeath.AutoSize = true;
            this.l_killsDeath.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_killsDeath.ForeColor = System.Drawing.Color.Gray;
            this.l_killsDeath.Location = new System.Drawing.Point(819, 57);
            this.l_killsDeath.Name = "l_killsDeath";
            this.l_killsDeath.Size = new System.Drawing.Size(33, 28);
            this.l_killsDeath.TabIndex = 12;
            this.l_killsDeath.Text = "-----";
            this.l_killsDeath.UseCompatibleTextRendering = true;
            // 
            // l_totalAssists
            // 
            this.l_totalAssists.AutoSize = true;
            this.l_totalAssists.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_totalAssists.ForeColor = System.Drawing.Color.Gray;
            this.l_totalAssists.Location = new System.Drawing.Point(526, 81);
            this.l_totalAssists.Name = "l_totalAssists";
            this.l_totalAssists.Size = new System.Drawing.Size(33, 28);
            this.l_totalAssists.TabIndex = 10;
            this.l_totalAssists.Text = "-----";
            this.l_totalAssists.UseCompatibleTextRendering = true;
            // 
            // l_totalDeaths
            // 
            this.l_totalDeaths.AutoSize = true;
            this.l_totalDeaths.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_totalDeaths.ForeColor = System.Drawing.Color.Gray;
            this.l_totalDeaths.Location = new System.Drawing.Point(526, 57);
            this.l_totalDeaths.Name = "l_totalDeaths";
            this.l_totalDeaths.Size = new System.Drawing.Size(33, 28);
            this.l_totalDeaths.TabIndex = 9;
            this.l_totalDeaths.Text = "-----";
            this.l_totalDeaths.UseCompatibleTextRendering = true;
            // 
            // l_totalKills
            // 
            this.l_totalKills.AutoSize = true;
            this.l_totalKills.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_totalKills.ForeColor = System.Drawing.Color.Gray;
            this.l_totalKills.Location = new System.Drawing.Point(526, 33);
            this.l_totalKills.Name = "l_totalKills";
            this.l_totalKills.Size = new System.Drawing.Size(33, 28);
            this.l_totalKills.TabIndex = 8;
            this.l_totalKills.Text = "-----";
            this.l_totalKills.UseCompatibleTextRendering = true;
            // 
            // l_time_played
            // 
            this.l_time_played.AutoSize = true;
            this.l_time_played.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_time_played.ForeColor = System.Drawing.Color.Gray;
            this.l_time_played.Location = new System.Drawing.Point(11, 342);
            this.l_time_played.Name = "l_time_played";
            this.l_time_played.Size = new System.Drawing.Size(65, 28);
            this.l_time_played.TabIndex = 7;
            this.l_time_played.Text = "-----------";
            this.l_time_played.UseCompatibleTextRendering = true;
            // 
            // l_rank_
            // 
            this.l_rank_.AutoSize = true;
            this.l_rank_.Font = new System.Drawing.Font("Roboto", 20F);
            this.l_rank_.ForeColor = System.Drawing.Color.Gray;
            this.l_rank_.Location = new System.Drawing.Point(9, 6);
            this.l_rank_.Name = "l_rank_";
            this.l_rank_.Size = new System.Drawing.Size(93, 39);
            this.l_rank_.TabIndex = 6;
            this.l_rank_.Text = "-----------";
            this.l_rank_.UseCompatibleTextRendering = true;
            // 
            // l_gamertag_
            // 
            this.l_gamertag_.AutoSize = true;
            this.l_gamertag_.Font = new System.Drawing.Font("Roboto", 14F);
            this.l_gamertag_.ForeColor = System.Drawing.Color.Gray;
            this.l_gamertag_.Location = new System.Drawing.Point(349, 6);
            this.l_gamertag_.Name = "l_gamertag_";
            this.l_gamertag_.Size = new System.Drawing.Size(65, 28);
            this.l_gamertag_.TabIndex = 5;
            this.l_gamertag_.Text = "-----------";
            this.l_gamertag_.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(215, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(9, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 336);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fxLabel3);
            this.tabPage2.Controls.Add(this.circularProgressBar2);
            this.tabPage2.Controls.Add(this.fxLabel2);
            this.tabPage2.Controls.Add(this.fxLabel1);
            this.tabPage2.Controls.Add(this.l_warzoneTopWeapons_5);
            this.tabPage2.Controls.Add(this.l_warzoneTopWeapons_4);
            this.tabPage2.Controls.Add(this.l_warzoneTopWeapons_3);
            this.tabPage2.Controls.Add(this.l_warzoneTopWeapons_2);
            this.tabPage2.Controls.Add(this.l_warzoneTopWeapons_1);
            this.tabPage2.Controls.Add(this.l_warzoneTopMedals_5);
            this.tabPage2.Controls.Add(this.l_warzoneTopMedals_4);
            this.tabPage2.Controls.Add(this.l_warzoneTopMedals_3);
            this.tabPage2.Controls.Add(this.l_warzoneTopMedals_2);
            this.tabPage2.Controls.Add(this.l_warzoneTopMedals_1);
            this.tabPage2.Controls.Add(this.pbWarzoneTopWeapons_5);
            this.tabPage2.Controls.Add(this.pbWarzoneTopWeapons_4);
            this.tabPage2.Controls.Add(this.pbWarzoneTopWeapons_3);
            this.tabPage2.Controls.Add(this.pbWarzoneTopWeapons_2);
            this.tabPage2.Controls.Add(this.pbWarzoneTopWeapons_1);
            this.tabPage2.Controls.Add(this.pbWarzoneTopMedals_5);
            this.tabPage2.Controls.Add(this.pbWarzoneTopMedals_4);
            this.tabPage2.Controls.Add(this.pbWarzoneTopMedals_3);
            this.tabPage2.Controls.Add(this.pbWarzoneTopMedals_2);
            this.tabPage2.Controls.Add(this.pbWarzoneTopMedals_1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Warzone";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // l_warzoneTopWeapons_5
            // 
            this.l_warzoneTopWeapons_5.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopWeapons_5.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopWeapons_5.Location = new System.Drawing.Point(906, 395);
            this.l_warzoneTopWeapons_5.Name = "l_warzoneTopWeapons_5";
            this.l_warzoneTopWeapons_5.Size = new System.Drawing.Size(64, 90);
            this.l_warzoneTopWeapons_5.TabIndex = 72;
            this.l_warzoneTopWeapons_5.Text = "-----";
            this.l_warzoneTopWeapons_5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopWeapons_5.UseCompatibleTextRendering = true;
            // 
            // l_warzoneTopWeapons_4
            // 
            this.l_warzoneTopWeapons_4.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopWeapons_4.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopWeapons_4.Location = new System.Drawing.Point(836, 395);
            this.l_warzoneTopWeapons_4.Name = "l_warzoneTopWeapons_4";
            this.l_warzoneTopWeapons_4.Size = new System.Drawing.Size(64, 90);
            this.l_warzoneTopWeapons_4.TabIndex = 71;
            this.l_warzoneTopWeapons_4.Text = "-----";
            this.l_warzoneTopWeapons_4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopWeapons_4.UseCompatibleTextRendering = true;
            // 
            // l_warzoneTopWeapons_3
            // 
            this.l_warzoneTopWeapons_3.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopWeapons_3.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopWeapons_3.Location = new System.Drawing.Point(766, 395);
            this.l_warzoneTopWeapons_3.Name = "l_warzoneTopWeapons_3";
            this.l_warzoneTopWeapons_3.Size = new System.Drawing.Size(64, 90);
            this.l_warzoneTopWeapons_3.TabIndex = 70;
            this.l_warzoneTopWeapons_3.Text = "-----";
            this.l_warzoneTopWeapons_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopWeapons_3.UseCompatibleTextRendering = true;
            // 
            // l_warzoneTopWeapons_2
            // 
            this.l_warzoneTopWeapons_2.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopWeapons_2.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopWeapons_2.Location = new System.Drawing.Point(696, 395);
            this.l_warzoneTopWeapons_2.Name = "l_warzoneTopWeapons_2";
            this.l_warzoneTopWeapons_2.Size = new System.Drawing.Size(64, 90);
            this.l_warzoneTopWeapons_2.TabIndex = 69;
            this.l_warzoneTopWeapons_2.Text = "-----";
            this.l_warzoneTopWeapons_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopWeapons_2.UseCompatibleTextRendering = true;
            // 
            // l_warzoneTopWeapons_1
            // 
            this.l_warzoneTopWeapons_1.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopWeapons_1.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopWeapons_1.Location = new System.Drawing.Point(626, 395);
            this.l_warzoneTopWeapons_1.Name = "l_warzoneTopWeapons_1";
            this.l_warzoneTopWeapons_1.Size = new System.Drawing.Size(64, 90);
            this.l_warzoneTopWeapons_1.TabIndex = 68;
            this.l_warzoneTopWeapons_1.Text = "-----";
            this.l_warzoneTopWeapons_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopWeapons_1.UseCompatibleTextRendering = true;
            // 
            // l_warzoneTopMedals_5
            // 
            this.l_warzoneTopMedals_5.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopMedals_5.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopMedals_5.Location = new System.Drawing.Point(289, 395);
            this.l_warzoneTopMedals_5.Name = "l_warzoneTopMedals_5";
            this.l_warzoneTopMedals_5.Size = new System.Drawing.Size(64, 90);
            this.l_warzoneTopMedals_5.TabIndex = 67;
            this.l_warzoneTopMedals_5.Text = "-----";
            this.l_warzoneTopMedals_5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopMedals_5.UseCompatibleTextRendering = true;
            // 
            // l_warzoneTopMedals_4
            // 
            this.l_warzoneTopMedals_4.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopMedals_4.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopMedals_4.Location = new System.Drawing.Point(219, 395);
            this.l_warzoneTopMedals_4.Name = "l_warzoneTopMedals_4";
            this.l_warzoneTopMedals_4.Size = new System.Drawing.Size(64, 90);
            this.l_warzoneTopMedals_4.TabIndex = 66;
            this.l_warzoneTopMedals_4.Text = "-----";
            this.l_warzoneTopMedals_4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopMedals_4.UseCompatibleTextRendering = true;
            // 
            // l_warzoneTopMedals_3
            // 
            this.l_warzoneTopMedals_3.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopMedals_3.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopMedals_3.Location = new System.Drawing.Point(149, 395);
            this.l_warzoneTopMedals_3.Name = "l_warzoneTopMedals_3";
            this.l_warzoneTopMedals_3.Size = new System.Drawing.Size(64, 90);
            this.l_warzoneTopMedals_3.TabIndex = 65;
            this.l_warzoneTopMedals_3.Text = "-----";
            this.l_warzoneTopMedals_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopMedals_3.UseCompatibleTextRendering = true;
            // 
            // l_warzoneTopMedals_2
            // 
            this.l_warzoneTopMedals_2.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopMedals_2.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopMedals_2.Location = new System.Drawing.Point(79, 395);
            this.l_warzoneTopMedals_2.Name = "l_warzoneTopMedals_2";
            this.l_warzoneTopMedals_2.Size = new System.Drawing.Size(60, 90);
            this.l_warzoneTopMedals_2.TabIndex = 64;
            this.l_warzoneTopMedals_2.Text = "-----";
            this.l_warzoneTopMedals_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopMedals_2.UseCompatibleTextRendering = true;
            // 
            // l_warzoneTopMedals_1
            // 
            this.l_warzoneTopMedals_1.Font = new System.Drawing.Font("Roboto", 8F);
            this.l_warzoneTopMedals_1.ForeColor = System.Drawing.Color.Gray;
            this.l_warzoneTopMedals_1.Location = new System.Drawing.Point(9, 395);
            this.l_warzoneTopMedals_1.Name = "l_warzoneTopMedals_1";
            this.l_warzoneTopMedals_1.Size = new System.Drawing.Size(61, 90);
            this.l_warzoneTopMedals_1.TabIndex = 63;
            this.l_warzoneTopMedals_1.Text = "-----";
            this.l_warzoneTopMedals_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_warzoneTopMedals_1.UseCompatibleTextRendering = true;
            // 
            // pbWarzoneTopWeapons_5
            // 
            this.pbWarzoneTopWeapons_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopWeapons_5.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_5.Image")));
            this.pbWarzoneTopWeapons_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_5.InitialImage")));
            this.pbWarzoneTopWeapons_5.Location = new System.Drawing.Point(906, 328);
            this.pbWarzoneTopWeapons_5.Name = "pbWarzoneTopWeapons_5";
            this.pbWarzoneTopWeapons_5.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopWeapons_5.TabIndex = 62;
            this.pbWarzoneTopWeapons_5.TabStop = false;
            // 
            // pbWarzoneTopWeapons_4
            // 
            this.pbWarzoneTopWeapons_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopWeapons_4.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_4.Image")));
            this.pbWarzoneTopWeapons_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_4.InitialImage")));
            this.pbWarzoneTopWeapons_4.Location = new System.Drawing.Point(836, 328);
            this.pbWarzoneTopWeapons_4.Name = "pbWarzoneTopWeapons_4";
            this.pbWarzoneTopWeapons_4.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopWeapons_4.TabIndex = 61;
            this.pbWarzoneTopWeapons_4.TabStop = false;
            // 
            // pbWarzoneTopWeapons_3
            // 
            this.pbWarzoneTopWeapons_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopWeapons_3.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_3.Image")));
            this.pbWarzoneTopWeapons_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_3.InitialImage")));
            this.pbWarzoneTopWeapons_3.Location = new System.Drawing.Point(766, 328);
            this.pbWarzoneTopWeapons_3.Name = "pbWarzoneTopWeapons_3";
            this.pbWarzoneTopWeapons_3.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopWeapons_3.TabIndex = 60;
            this.pbWarzoneTopWeapons_3.TabStop = false;
            // 
            // pbWarzoneTopWeapons_2
            // 
            this.pbWarzoneTopWeapons_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopWeapons_2.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_2.Image")));
            this.pbWarzoneTopWeapons_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_2.InitialImage")));
            this.pbWarzoneTopWeapons_2.Location = new System.Drawing.Point(696, 328);
            this.pbWarzoneTopWeapons_2.Name = "pbWarzoneTopWeapons_2";
            this.pbWarzoneTopWeapons_2.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopWeapons_2.TabIndex = 59;
            this.pbWarzoneTopWeapons_2.TabStop = false;
            // 
            // pbWarzoneTopWeapons_1
            // 
            this.pbWarzoneTopWeapons_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopWeapons_1.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_1.Image")));
            this.pbWarzoneTopWeapons_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopWeapons_1.InitialImage")));
            this.pbWarzoneTopWeapons_1.Location = new System.Drawing.Point(626, 328);
            this.pbWarzoneTopWeapons_1.Name = "pbWarzoneTopWeapons_1";
            this.pbWarzoneTopWeapons_1.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopWeapons_1.TabIndex = 58;
            this.pbWarzoneTopWeapons_1.TabStop = false;
            // 
            // pbWarzoneTopMedals_5
            // 
            this.pbWarzoneTopMedals_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopMedals_5.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_5.Image")));
            this.pbWarzoneTopMedals_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_5.InitialImage")));
            this.pbWarzoneTopMedals_5.Location = new System.Drawing.Point(289, 328);
            this.pbWarzoneTopMedals_5.Name = "pbWarzoneTopMedals_5";
            this.pbWarzoneTopMedals_5.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopMedals_5.TabIndex = 57;
            this.pbWarzoneTopMedals_5.TabStop = false;
            // 
            // pbWarzoneTopMedals_4
            // 
            this.pbWarzoneTopMedals_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopMedals_4.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_4.Image")));
            this.pbWarzoneTopMedals_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_4.InitialImage")));
            this.pbWarzoneTopMedals_4.Location = new System.Drawing.Point(219, 328);
            this.pbWarzoneTopMedals_4.Name = "pbWarzoneTopMedals_4";
            this.pbWarzoneTopMedals_4.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopMedals_4.TabIndex = 56;
            this.pbWarzoneTopMedals_4.TabStop = false;
            // 
            // pbWarzoneTopMedals_3
            // 
            this.pbWarzoneTopMedals_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopMedals_3.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_3.Image")));
            this.pbWarzoneTopMedals_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_3.InitialImage")));
            this.pbWarzoneTopMedals_3.Location = new System.Drawing.Point(149, 328);
            this.pbWarzoneTopMedals_3.Name = "pbWarzoneTopMedals_3";
            this.pbWarzoneTopMedals_3.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopMedals_3.TabIndex = 55;
            this.pbWarzoneTopMedals_3.TabStop = false;
            // 
            // pbWarzoneTopMedals_2
            // 
            this.pbWarzoneTopMedals_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopMedals_2.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_2.Image")));
            this.pbWarzoneTopMedals_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_2.InitialImage")));
            this.pbWarzoneTopMedals_2.Location = new System.Drawing.Point(79, 328);
            this.pbWarzoneTopMedals_2.Name = "pbWarzoneTopMedals_2";
            this.pbWarzoneTopMedals_2.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopMedals_2.TabIndex = 54;
            this.pbWarzoneTopMedals_2.TabStop = false;
            // 
            // pbWarzoneTopMedals_1
            // 
            this.pbWarzoneTopMedals_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarzoneTopMedals_1.Image = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_1.Image")));
            this.pbWarzoneTopMedals_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWarzoneTopMedals_1.InitialImage")));
            this.pbWarzoneTopMedals_1.Location = new System.Drawing.Point(9, 328);
            this.pbWarzoneTopMedals_1.Name = "pbWarzoneTopMedals_1";
            this.pbWarzoneTopMedals_1.Size = new System.Drawing.Size(64, 64);
            this.pbWarzoneTopMedals_1.TabIndex = 53;
            this.pbWarzoneTopMedals_1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arena";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(976, 491);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Last Matches";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(976, 491);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Campaign";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(976, 491);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Settings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(976, 491);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "DEBUG";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asasToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(97, 26);
            // 
            // asasToolStripMenuItem
            // 
            this.asasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asToolStripMenuItem});
            this.asasToolStripMenuItem.Name = "asasToolStripMenuItem";
            this.asasToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.asasToolStripMenuItem.Text = "asas";
            // 
            // asToolStripMenuItem
            // 
            this.asToolStripMenuItem.Name = "asToolStripMenuItem";
            this.asToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.asToolStripMenuItem.Text = "as";
            // 
            // l_h_medals
            // 
            this.l_h_medals.BackColor = System.Drawing.Color.Transparent;
            this.l_h_medals.Border = MaterialHaloSharp.Special_Controls.fxLabel.BorderType.none;
            this.l_h_medals.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.l_h_medals.FillColor = System.Drawing.Color.CornflowerBlue;
            this.l_h_medals.FillOpacity = 255;
            this.l_h_medals.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.l_h_medals.ForeColor = System.Drawing.Color.LightGray;
            this.l_h_medals.GlowAnimationSpeed = 100;
            this.l_h_medals.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.l_h_medals.GlowItensity = 10;
            this.l_h_medals.GlowType = MaterialHaloSharp.Special_Controls.fxLabel.GlowTypes.AlwaysGlow;
            this.l_h_medals.GradientStrength = 150;
            this.l_h_medals.Image = null;
            this.l_h_medals.ImageAlign = MaterialHaloSharp.Special_Controls.fxLabel.ImageAlignments.Center;
            this.l_h_medals.Location = new System.Drawing.Point(271, 297);
            this.l_h_medals.Name = "l_h_medals";
            this.l_h_medals.RoundRadius = 3;
            this.l_h_medals.Size = new System.Drawing.Size(108, 28);
            this.l_h_medals.TabIndex = 31;
            this.l_h_medals.Text = "Top-Medals";
            this.l_h_medals.TextAlign = System.Drawing.StringAlignment.Near;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimatorDuration = 500;
            this.circularProgressBar1.AnimatorFunction = ((WinFormAnimation.Functions.Function)(resources.GetObject("circularProgressBar1.AnimatorFunction")));
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circularProgressBar1.Caption = "Loading";
            this.circularProgressBar1.CaptionMargin = -30;
            this.circularProgressBar1.Font = new System.Drawing.Font("Roboto", 14F);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.LightGray;
            this.circularProgressBar1.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(57)))), ((int)(((byte)(3)))));
            this.circularProgressBar1.InnerCircleMargin = 0;
            this.circularProgressBar1.InnerCircleWidth = 0;
            this.circularProgressBar1.Location = new System.Drawing.Point(353, 33);
            this.circularProgressBar1.MaxValue = 100F;
            this.circularProgressBar1.MinValue = 0F;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(57)))), ((int)(((byte)(3)))));
            this.circularProgressBar1.OuterCircleMargin = 0;
            this.circularProgressBar1.OuterCircleWidth = 0;
            this.circularProgressBar1.ProgressCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(26)))));
            this.circularProgressBar1.ProgressCircleStartAngle = 180;
            this.circularProgressBar1.ProgressCircleWidth = 9;
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.SubText = null;
            this.circularProgressBar1.SubTextColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.SupSubFont = new System.Drawing.Font("Microsoft Sans Serif", 4.125F);
            this.circularProgressBar1.SupText = null;
            this.circularProgressBar1.SupTextColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.TotalAngle = 180;
            this.circularProgressBar1.Value = 0F;
            // 
            // fxLabel3
            // 
            this.fxLabel3.BackColor = System.Drawing.Color.Transparent;
            this.fxLabel3.Border = MaterialHaloSharp.Special_Controls.fxLabel.BorderType.none;
            this.fxLabel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fxLabel3.FillColor = System.Drawing.Color.Maroon;
            this.fxLabel3.FillOpacity = 255;
            this.fxLabel3.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fxLabel3.ForeColor = System.Drawing.Color.LightGray;
            this.fxLabel3.GlowAnimationSpeed = 100;
            this.fxLabel3.GlowColor = System.Drawing.Color.Black;
            this.fxLabel3.GlowItensity = 10;
            this.fxLabel3.GlowType = MaterialHaloSharp.Special_Controls.fxLabel.GlowTypes.AlwaysGlow;
            this.fxLabel3.GradientStrength = 150;
            this.fxLabel3.Image = null;
            this.fxLabel3.ImageAlign = MaterialHaloSharp.Special_Controls.fxLabel.ImageAlignments.Center;
            this.fxLabel3.Location = new System.Drawing.Point(437, 293);
            this.fxLabel3.Name = "fxLabel3";
            this.fxLabel3.RoundRadius = 3;
            this.fxLabel3.Size = new System.Drawing.Size(102, 29);
            this.fxLabel3.TabIndex = 77;
            this.fxLabel3.Text = "Win / Lost";
            this.fxLabel3.TextAlign = System.Drawing.StringAlignment.Near;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimatorDuration = 500;
            this.circularProgressBar2.AnimatorFunction = ((WinFormAnimation.Functions.Function)(resources.GetObject("circularProgressBar2.AnimatorFunction")));
            this.circularProgressBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circularProgressBar2.Caption = "Loading";
            this.circularProgressBar2.CaptionMargin = -30;
            this.circularProgressBar2.Font = new System.Drawing.Font("Roboto", 14F);
            this.circularProgressBar2.ForeColor = System.Drawing.Color.LightGray;
            this.circularProgressBar2.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(57)))), ((int)(((byte)(3)))));
            this.circularProgressBar2.InnerCircleMargin = 0;
            this.circularProgressBar2.InnerCircleWidth = 0;
            this.circularProgressBar2.Location = new System.Drawing.Point(416, 328);
            this.circularProgressBar2.MaxValue = 100F;
            this.circularProgressBar2.MinValue = 0F;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(57)))), ((int)(((byte)(3)))));
            this.circularProgressBar2.OuterCircleMargin = 0;
            this.circularProgressBar2.OuterCircleWidth = 0;
            this.circularProgressBar2.ProgressCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(26)))));
            this.circularProgressBar2.ProgressCircleStartAngle = 180;
            this.circularProgressBar2.ProgressCircleWidth = 9;
            this.circularProgressBar2.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar2.SubText = null;
            this.circularProgressBar2.SubTextColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.SupSubFont = new System.Drawing.Font("Microsoft Sans Serif", 4.125F);
            this.circularProgressBar2.SupText = null;
            this.circularProgressBar2.SupTextColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.TabIndex = 76;
            this.circularProgressBar2.TotalAngle = 180;
            this.circularProgressBar2.Value = 0F;
            // 
            // fxLabel2
            // 
            this.fxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fxLabel2.Border = MaterialHaloSharp.Special_Controls.fxLabel.BorderType.none;
            this.fxLabel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fxLabel2.FillColor = System.Drawing.Color.Maroon;
            this.fxLabel2.FillOpacity = 255;
            this.fxLabel2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fxLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.fxLabel2.GlowAnimationSpeed = 100;
            this.fxLabel2.GlowColor = System.Drawing.Color.Black;
            this.fxLabel2.GlowItensity = 10;
            this.fxLabel2.GlowType = MaterialHaloSharp.Special_Controls.fxLabel.GlowTypes.AlwaysGlow;
            this.fxLabel2.GradientStrength = 150;
            this.fxLabel2.Image = null;
            this.fxLabel2.ImageAlign = MaterialHaloSharp.Special_Controls.fxLabel.ImageAlignments.Center;
            this.fxLabel2.Location = new System.Drawing.Point(9, 293);
            this.fxLabel2.Name = "fxLabel2";
            this.fxLabel2.RoundRadius = 3;
            this.fxLabel2.Size = new System.Drawing.Size(204, 29);
            this.fxLabel2.TabIndex = 75;
            this.fxLabel2.Text = "Top-Medals";
            this.fxLabel2.TextAlign = System.Drawing.StringAlignment.Near;
            // 
            // fxLabel1
            // 
            this.fxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fxLabel1.Border = MaterialHaloSharp.Special_Controls.fxLabel.BorderType.none;
            this.fxLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fxLabel1.FillColor = System.Drawing.Color.Maroon;
            this.fxLabel1.FillOpacity = 255;
            this.fxLabel1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fxLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.fxLabel1.GlowAnimationSpeed = 100;
            this.fxLabel1.GlowColor = System.Drawing.Color.Black;
            this.fxLabel1.GlowItensity = 10;
            this.fxLabel1.GlowType = MaterialHaloSharp.Special_Controls.fxLabel.GlowTypes.AlwaysGlow;
            this.fxLabel1.GradientStrength = 150;
            this.fxLabel1.Image = null;
            this.fxLabel1.ImageAlign = MaterialHaloSharp.Special_Controls.fxLabel.ImageAlignments.Center;
            this.fxLabel1.Location = new System.Drawing.Point(626, 293);
            this.fxLabel1.Name = "fxLabel1";
            this.fxLabel1.RoundRadius = 3;
            this.fxLabel1.Size = new System.Drawing.Size(204, 29);
            this.fxLabel1.TabIndex = 74;
            this.fxLabel1.Text = "Top-Weapons";
            this.fxLabel1.TextAlign = System.Drawing.StringAlignment.Near;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 637);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Text = "Halo5 API-Test";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_medal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopWeapons_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarzoneTopMedals_1)).EndInit();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label l_gamertag_;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label l_rank_;
        private System.Windows.Forms.Label l_time_played;
        private System.Windows.Forms.Label l_totalDeaths;
        private System.Windows.Forms.Label l_totalKills;
        private System.Windows.Forms.Label l_totalAssists;
        private System.Windows.Forms.Label l_killsAssistsDeath;
        private System.Windows.Forms.Label l_killsDeath;
        private System.Windows.Forms.Label l_headshots;
        private System.Windows.Forms.Label l_assassinations;
        private System.Windows.Forms.Label l_totalMatchesLost;
        private System.Windows.Forms.Label l_totalMatchesWon;
        private System.Windows.Forms.Label l_totalMatchesCount;
        private MaterialDivider materialDivider1;
        private System.Windows.Forms.Label l_totalShotsAccuracy;
        private System.Windows.Forms.Label l_totalShotsLanded;
        private System.Windows.Forms.Label l_totalShotsFired;
        private System.Windows.Forms.Label l_med_10;
        private System.Windows.Forms.Label l_med_9;
        private System.Windows.Forms.Label l_med_8;
        private System.Windows.Forms.Label l_med_7;
        private System.Windows.Forms.Label l_med_6;
        private System.Windows.Forms.Label l_med_5;
        private System.Windows.Forms.Label l_med_4;
        private System.Windows.Forms.Label l_med_3;
        private System.Windows.Forms.Label l_med_2;
        private System.Windows.Forms.Label l_med_1;
        private System.Windows.Forms.PictureBox pb_medal10;
        private System.Windows.Forms.PictureBox pb_medal9;
        private System.Windows.Forms.PictureBox pb_medal8;
        private System.Windows.Forms.PictureBox pb_medal7;
        private System.Windows.Forms.PictureBox pb_medal6;
        private System.Windows.Forms.PictureBox pb_medal5;
        private System.Windows.Forms.PictureBox pb_medal4;
        private System.Windows.Forms.PictureBox pb_medal3;
        private System.Windows.Forms.PictureBox pb_medal2;
        private System.Windows.Forms.PictureBox pb_medal1;
        private fxLabel l_h_medals;
        private System.Windows.Forms.Label l_warzoneTopWeapons_5;
        private System.Windows.Forms.Label l_warzoneTopWeapons_4;
        private System.Windows.Forms.Label l_warzoneTopWeapons_3;
        private System.Windows.Forms.Label l_warzoneTopWeapons_2;
        private System.Windows.Forms.Label l_warzoneTopWeapons_1;
        private System.Windows.Forms.Label l_warzoneTopMedals_5;
        private System.Windows.Forms.Label l_warzoneTopMedals_4;
        private System.Windows.Forms.Label l_warzoneTopMedals_3;
        private System.Windows.Forms.Label l_warzoneTopMedals_2;
        private System.Windows.Forms.Label l_warzoneTopMedals_1;
        private System.Windows.Forms.PictureBox pbWarzoneTopWeapons_5;
        private System.Windows.Forms.PictureBox pbWarzoneTopWeapons_4;
        private System.Windows.Forms.PictureBox pbWarzoneTopWeapons_3;
        private System.Windows.Forms.PictureBox pbWarzoneTopWeapons_2;
        private System.Windows.Forms.PictureBox pbWarzoneTopWeapons_1;
        private System.Windows.Forms.PictureBox pbWarzoneTopMedals_5;
        private System.Windows.Forms.PictureBox pbWarzoneTopMedals_4;
        private System.Windows.Forms.PictureBox pbWarzoneTopMedals_3;
        private System.Windows.Forms.PictureBox pbWarzoneTopMedals_2;
        private System.Windows.Forms.PictureBox pbWarzoneTopMedals_1;
        private fxLabel fxLabel1;
        private fxLabel fxLabel2;
        private System.Windows.Forms.TabPage tabPage7;
        private fxLabel fxLabel3;
        private CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
    }
}


namespace GameLauncher
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnLogOut = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnMusicPanel = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnSetting = new FontAwesome.Sharp.IconButton();
            btnMarketing = new FontAwesome.Sharp.IconButton();
            btnCustomers = new FontAwesome.Sharp.IconButton();
            btnProducts = new FontAwesome.Sharp.IconButton();
            btnOrders = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnHome = new PictureBox();
            panel1 = new Panel();
            panelTitleBar = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnExit2 = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            LoadingTimer = new System.Windows.Forms.Timer(components);
            LoadingBackPanel = new Panel();
            labelDate = new Label();
            labelTime = new Label();
            pictureBox1 = new PictureBox();
            LoadingGif = new PictureBox();
            panelDesktop = new Panel();
            button2 = new Button();
            panel454 = new Panel();
            siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(components);
            notifyIcon1 = new NotifyIcon(components);
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panel1.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panel7.SuspendLayout();
            LoadingBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoadingGif).BeginInit();
            panelDesktop.SuspendLayout();
            panel454.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnMusicPanel);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnSetting);
            panelMenu.Controls.Add(btnMarketing);
            panelMenu.Controls.Add(btnCustomers);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(btnOrders);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 898);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.Gainsboro;
            btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnLogOut.IconColor = Color.Gainsboro;
            btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogOut.IconSize = 26;
            btnLogOut.ImageAlign = ContentAlignment.MiddleRight;
            btnLogOut.Location = new Point(0, 808);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(220, 41);
            btnLogOut.TabIndex = 15;
            btnLogOut.Tag = "btnExit";
            btnLogOut.Text = "Log Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleRight;
            btnLogOut.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Sitrox;
            btnSettings.IconColor = Color.Gainsboro;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 580);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(220, 60);
            btnSettings.TabIndex = 14;
            btnSettings.Tag = "btnPerformance";
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnMusicPanel
            // 
            btnMusicPanel.Dock = DockStyle.Top;
            btnMusicPanel.FlatAppearance.BorderSize = 0;
            btnMusicPanel.FlatStyle = FlatStyle.Flat;
            btnMusicPanel.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusicPanel.ForeColor = Color.Gainsboro;
            btnMusicPanel.IconChar = FontAwesome.Sharp.IconChar.Spotify;
            btnMusicPanel.IconColor = Color.Gainsboro;
            btnMusicPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMusicPanel.ImageAlign = ContentAlignment.MiddleLeft;
            btnMusicPanel.Location = new Point(0, 520);
            btnMusicPanel.Name = "btnMusicPanel";
            btnMusicPanel.Size = new Size(220, 60);
            btnMusicPanel.TabIndex = 13;
            btnMusicPanel.Tag = "btnPerformance";
            btnMusicPanel.Text = "Music";
            btnMusicPanel.TextAlign = ContentAlignment.MiddleLeft;
            btnMusicPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMusicPanel.UseVisualStyleBackColor = true;
            btnMusicPanel.Click += btnMusicPanel_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.GaugeSimpleHigh;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 460);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(220, 60);
            iconButton1.TabIndex = 12;
            iconButton1.Tag = "btnPerformance";
            iconButton1.Text = "Performance";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click_2;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Cambria", 17F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.ImageAlign = ContentAlignment.MiddleRight;
            btnExit.Location = new Point(0, 849);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(220, 49);
            btnExit.TabIndex = 11;
            btnExit.Tag = "btnExit";
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSetting.ForeColor = Color.Gainsboro;
            btnSetting.IconChar = FontAwesome.Sharp.IconChar.MicrophoneAlt;
            btnSetting.IconColor = Color.Gainsboro;
            btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 400);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(220, 60);
            btnSetting.TabIndex = 8;
            btnSetting.Tag = "btnSetting";
            btnSetting.Text = "Social";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnMarketing
            // 
            btnMarketing.Dock = DockStyle.Top;
            btnMarketing.FlatAppearance.BorderSize = 0;
            btnMarketing.FlatStyle = FlatStyle.Flat;
            btnMarketing.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMarketing.ForeColor = Color.Gainsboro;
            btnMarketing.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            btnMarketing.IconColor = Color.Gainsboro;
            btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMarketing.ImageAlign = ContentAlignment.MiddleLeft;
            btnMarketing.Location = new Point(0, 340);
            btnMarketing.Name = "btnMarketing";
            btnMarketing.Size = new Size(220, 60);
            btnMarketing.TabIndex = 5;
            btnMarketing.Tag = "btnMarketing";
            btnMarketing.Text = "EA Games";
            btnMarketing.TextAlign = ContentAlignment.MiddleLeft;
            btnMarketing.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMarketing.UseVisualStyleBackColor = true;
            btnMarketing.Click += btnMarketing_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomers.ForeColor = Color.Gainsboro;
            btnCustomers.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            btnCustomers.IconColor = Color.Gainsboro;
            btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 280);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(220, 60);
            btnCustomers.TabIndex = 4;
            btnCustomers.Tag = "btnCustomers";
            btnCustomers.Text = "Ubisoft Connect";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.Gainsboro;
            btnProducts.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            btnProducts.IconColor = Color.Gainsboro;
            btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 220);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(220, 60);
            btnProducts.TabIndex = 3;
            btnProducts.Tag = "btnProducts";
            btnProducts.Text = "Epic Games";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrders.ForeColor = Color.Gainsboro;
            btnOrders.IconChar = FontAwesome.Sharp.IconChar.Steam;
            btnOrders.IconColor = Color.Gainsboro;
            btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOrders.IconSize = 44;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 160);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(220, 60);
            btnOrders.TabIndex = 2;
            btnOrders.Tag = "btnOrders";
            btnOrders.Text = " Steam Games";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            btnDashboard.IconColor = Color.Gainsboro;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Tag = "btnDashboard";
            btnDashboard.Text = "All Games";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 100);
            panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = Properties.Resources.GameLauncherTopCornerLogo;
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Location = new Point(3, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(211, 100);
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Tag = "btnHome";
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(panelTitleBar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 62);
            panel1.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Black;
            panelTitleBar.Controls.Add(panel3);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnExit2);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1200, 62);
            panelTitleBar.TabIndex = 2;
            panelTitleBar.Tag = "panelTitleBar";
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(700, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 160);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(31, 30, 68);
            panel4.Location = new Point(-31, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(259, 157);
            panel4.TabIndex = 3;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            btnMaximize.IconColor = Color.DarkGray;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 15;
            btnMaximize.Location = new Point(1150, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(22, 21);
            btnMaximize.TabIndex = 7;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximise_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMinimize.IconColor = Color.DarkGray;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 15;
            btnMinimize.Location = new Point(1122, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(22, 21);
            btnMinimize.TabIndex = 6;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit2
            // 
            btnExit2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit2.FlatAppearance.BorderSize = 0;
            btnExit2.FlatStyle = FlatStyle.Flat;
            btnExit2.ForeColor = SystemColors.ControlLightLight;
            btnExit2.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit2.IconColor = Color.DarkGray;
            btnExit2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit2.IconSize = 15;
            btnExit2.Location = new Point(1178, 0);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(22, 21);
            btnExit2.TabIndex = 2;
            btnExit2.UseVisualStyleBackColor = true;
            btnExit2.Click += btnExit2_Click;
            btnExit2.MouseLeave += btnExit2_MouseLeave;
            btnExit2.MouseHover += btnExit2_MouseHover;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.BackColor = Color.Transparent;
            lblTitleChildForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(63, 25);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(56, 21);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Tag = "lblTitleChildForm";
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.Transparent;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 45;
            iconCurrentChildForm.Location = new Point(6, 11);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(51, 45);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            iconCurrentChildForm.Click += iconCurrentChildForm_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Red;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(230, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(1190, 10);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Red;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(220, 62);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 836);
            panel6.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(797, 597);
            panel7.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(797, 597);
            panel8.TabIndex = 2;
            // 
            // LoadingTimer
            // 
            LoadingTimer.Enabled = true;
            LoadingTimer.Interval = 650;
            LoadingTimer.Tick += LoadingTimer_Tick;
            // 
            // LoadingBackPanel
            // 
            LoadingBackPanel.Controls.Add(labelDate);
            LoadingBackPanel.Controls.Add(labelTime);
            LoadingBackPanel.Controls.Add(pictureBox1);
            LoadingBackPanel.Controls.Add(LoadingGif);
            LoadingBackPanel.Controls.Add(panelDesktop);
            LoadingBackPanel.Dock = DockStyle.Fill;
            LoadingBackPanel.Location = new Point(0, 0);
            LoadingBackPanel.Name = "LoadingBackPanel";
            LoadingBackPanel.Size = new Size(1200, 836);
            LoadingBackPanel.TabIndex = 0;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = Color.Black;
            labelDate.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(26, 45);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(66, 25);
            labelDate.TabIndex = 10;
            labelDate.Text = "{Date}";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.Black;
            labelTime.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(16, 13);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(88, 32);
            labelTime.TabIndex = 9;
            labelTime.Text = "{Time}";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.image_processing20210304_20159_1dq836t_1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 836);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoadingGif
            // 
            LoadingGif.Dock = DockStyle.Fill;
            LoadingGif.Image = (Image)resources.GetObject("LoadingGif.Image");
            LoadingGif.Location = new Point(0, 0);
            LoadingGif.MaximumSize = new Size(1200, 857);
            LoadingGif.MinimumSize = new Size(1200, 857);
            LoadingGif.Name = "LoadingGif";
            LoadingGif.Size = new Size(1200, 857);
            LoadingGif.TabIndex = 5;
            LoadingGif.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(button2);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1200, 836);
            panelDesktop.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(40, 95);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel454
            // 
            panel454.BackColor = Color.FromArgb(25, 25, 25);
            panel454.Controls.Add(LoadingBackPanel);
            panel454.Dock = DockStyle.Fill;
            panel454.Location = new Point(220, 62);
            panel454.Name = "panel454";
            panel454.Size = new Size(1200, 836);
            panel454.TabIndex = 8;
            // 
            // siticoneAnimateWindow1
            // 
            siticoneAnimateWindow1.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_SLIDE;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1420, 898);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel454);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1436, 937);
            MinimumSize = new Size(800, 600);
            Name = "FormMainMenu";
            Text = " Game Launcher V0.2";
            Load += FormMainMenu_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panel1.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panel7.ResumeLayout(false);
            LoadingBackPanel.ResumeLayout(false);
            LoadingBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoadingGif).EndInit();
            panelDesktop.ResumeLayout(false);
            panel454.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnMarketing;
        private FontAwesome.Sharp.IconButton btnCustomers;
        private FontAwesome.Sharp.IconButton btnProducts;
        private FontAwesome.Sharp.IconButton btnOrders;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Panel panel2;
        private Panel panelMenu;
        private Panel panel1;
        private Panel panelTitleBar;
        private PictureBox btnHome;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private FontAwesome.Sharp.IconButton btnExit2;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private System.Windows.Forms.Timer LoadingTimer;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnExit;
        private Panel LoadingBackPanel;
        private Label labelDate;
        private Label labelTime;
        private PictureBox pictureBox1;
        private PictureBox LoadingGif;
        private Panel panelDesktop;
        private Panel panel454;
        private FontAwesome.Sharp.IconButton btnMusicPanel;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnSettings;
        private Button button2;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private NotifyIcon notifyIcon1;
    }
}
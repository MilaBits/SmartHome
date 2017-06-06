namespace SmartHome
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanelNavBar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonProfileSettings = new System.Windows.Forms.Button();
            this.buttonMusicSettings = new System.Windows.Forms.Button();
            this.buttonLockSettings = new System.Windows.Forms.Button();
            this.buttonLightSettings = new System.Windows.Forms.Button();
            this.buttonCoffeeSettings = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelLoggedInAs = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelNFC = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelContentBox = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTopBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.profileSettings = new SmartHome.ProfileSettings();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.musicSettings = new SmartHome.MusicSettings();
            this.doorlockSettings = new SmartHome.DoorlockSettings();
            this.lightSettings = new SmartHome.LightSettings();
            this.flowLayoutPanelNavBar.SuspendLayout();
            this.panelContentBox.SuspendLayout();
            this.flowLayoutPanelTopBar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            this.flowLayoutPanelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.flowLayoutPanelNavBar.Controls.Add(this.buttonProfileSettings);
            this.flowLayoutPanelNavBar.Controls.Add(this.buttonMusicSettings);
            this.flowLayoutPanelNavBar.Controls.Add(this.buttonLockSettings);
            this.flowLayoutPanelNavBar.Controls.Add(this.buttonLightSettings);
            this.flowLayoutPanelNavBar.Controls.Add(this.buttonCoffeeSettings);
            this.flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 225);
            this.flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            this.flowLayoutPanelNavBar.Size = new System.Drawing.Size(1904, 50);
            this.flowLayoutPanelNavBar.TabIndex = 10;
            // 
            // buttonProfileSettings
            // 
            this.buttonProfileSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfileSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonProfileSettings.FlatAppearance.BorderSize = 0;
            this.buttonProfileSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfileSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfileSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonProfileSettings.Location = new System.Drawing.Point(3, 3);
            this.buttonProfileSettings.Name = "buttonProfileSettings";
            this.buttonProfileSettings.Size = new System.Drawing.Size(200, 50);
            this.buttonProfileSettings.TabIndex = 2;
            this.buttonProfileSettings.Text = "Profile Settings";
            this.buttonProfileSettings.UseVisualStyleBackColor = false;
            this.buttonProfileSettings.Click += new System.EventHandler(this.buttonProfileSettings_Click);
            // 
            // buttonMusicSettings
            // 
            this.buttonMusicSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMusicSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonMusicSettings.FlatAppearance.BorderSize = 0;
            this.buttonMusicSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMusicSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusicSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonMusicSettings.Location = new System.Drawing.Point(209, 3);
            this.buttonMusicSettings.Name = "buttonMusicSettings";
            this.buttonMusicSettings.Size = new System.Drawing.Size(200, 50);
            this.buttonMusicSettings.TabIndex = 3;
            this.buttonMusicSettings.Text = "Music Settings";
            this.buttonMusicSettings.UseVisualStyleBackColor = false;
            this.buttonMusicSettings.Click += new System.EventHandler(this.buttonMusicSettings_Click);
            // 
            // buttonLockSettings
            // 
            this.buttonLockSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLockSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonLockSettings.FlatAppearance.BorderSize = 0;
            this.buttonLockSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLockSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLockSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonLockSettings.Location = new System.Drawing.Point(415, 3);
            this.buttonLockSettings.Name = "buttonLockSettings";
            this.buttonLockSettings.Size = new System.Drawing.Size(200, 50);
            this.buttonLockSettings.TabIndex = 4;
            this.buttonLockSettings.Text = "Doorlock Settings";
            this.buttonLockSettings.UseVisualStyleBackColor = false;
            this.buttonLockSettings.Click += new System.EventHandler(this.buttonLockSettings_Click);
            // 
            // buttonLightSettings
            // 
            this.buttonLightSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLightSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonLightSettings.FlatAppearance.BorderSize = 0;
            this.buttonLightSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLightSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLightSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonLightSettings.Location = new System.Drawing.Point(621, 3);
            this.buttonLightSettings.Name = "buttonLightSettings";
            this.buttonLightSettings.Size = new System.Drawing.Size(200, 50);
            this.buttonLightSettings.TabIndex = 5;
            this.buttonLightSettings.Text = "Light Settings";
            this.buttonLightSettings.UseVisualStyleBackColor = false;
            this.buttonLightSettings.Click += new System.EventHandler(this.buttonLightSettings_Click);
            // 
            // buttonCoffeeSettings
            // 
            this.buttonCoffeeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCoffeeSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonCoffeeSettings.FlatAppearance.BorderSize = 0;
            this.buttonCoffeeSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCoffeeSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCoffeeSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonCoffeeSettings.Location = new System.Drawing.Point(827, 3);
            this.buttonCoffeeSettings.Name = "buttonCoffeeSettings";
            this.buttonCoffeeSettings.Size = new System.Drawing.Size(200, 50);
            this.buttonCoffeeSettings.TabIndex = 6;
            this.buttonCoffeeSettings.Text = "Coffee Settings";
            this.buttonCoffeeSettings.UseVisualStyleBackColor = false;
            this.buttonCoffeeSettings.Click += new System.EventHandler(this.buttonCoffeeSettings_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelTitle.Location = new System.Drawing.Point(12, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(420, 75);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Smart Home";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonClose.Location = new System.Drawing.Point(1874, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "r";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelLoggedInAs
            // 
            this.labelLoggedInAs.AutoSize = true;
            this.labelLoggedInAs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedInAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelLoggedInAs.Location = new System.Drawing.Point(14, 13);
            this.labelLoggedInAs.Name = "labelLoggedInAs";
            this.labelLoggedInAs.Size = new System.Drawing.Size(215, 28);
            this.labelLoggedInAs.TabIndex = 1;
            this.labelLoggedInAs.Text = "No user logged in";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonLogIn.FlatAppearance.BorderSize = 0;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.buttonLogIn.Location = new System.Drawing.Point(4, 103);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(145, 45);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // labelNFC
            // 
            this.labelNFC.AutoSize = true;
            this.labelNFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.labelNFC.Location = new System.Drawing.Point(16, 41);
            this.labelNFC.Name = "labelNFC";
            this.labelNFC.Size = new System.Drawing.Size(0, 15);
            this.labelNFC.TabIndex = 6;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.buttonLogOut.Location = new System.Drawing.Point(152, 103);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(145, 45);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.TabStop = false;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panelContentBox
            // 
            this.panelContentBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelContentBox.Controls.Add(this.buttonLogOut);
            this.panelContentBox.Controls.Add(this.labelLoggedInAs);
            this.panelContentBox.Controls.Add(this.buttonLogIn);
            this.panelContentBox.Controls.Add(this.labelNFC);
            this.panelContentBox.Location = new System.Drawing.Point(1575, 47);
            this.panelContentBox.Name = "panelContentBox";
            this.panelContentBox.Size = new System.Drawing.Size(300, 150);
            this.panelContentBox.TabIndex = 7;
            // 
            // flowLayoutPanelTopBar
            // 
            this.flowLayoutPanelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.flowLayoutPanelTopBar.Controls.Add(this.buttonClose);
            this.flowLayoutPanelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelTopBar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelTopBar.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTopBar.Name = "flowLayoutPanelTopBar";
            this.flowLayoutPanelTopBar.Size = new System.Drawing.Size(1904, 30);
            this.flowLayoutPanelTopBar.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.AllowDrop = true;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelHeader.Controls.Add(this.panelContentBox);
            this.panelHeader.Controls.Add(this.flowLayoutPanelTopBar);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1904, 225);
            this.panelHeader.TabIndex = 9;
            // 
            // profileSettings
            // 
            this.profileSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.profileSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileSettings.Location = new System.Drawing.Point(0, 275);
            this.profileSettings.Name = "profileSettings";
            this.profileSettings.Size = new System.Drawing.Size(1904, 800);
            this.profileSettings.TabIndex = 11;
            this.profileSettings.Visible = false;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM7";
            // 
            // musicSettings
            // 
            this.musicSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.musicSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.musicSettings.Location = new System.Drawing.Point(-16, 1075);
            this.musicSettings.Name = "musicSettings";
            this.musicSettings.Size = new System.Drawing.Size(1920, 0);
            this.musicSettings.TabIndex = 12;
            this.musicSettings.Visible = false;
            // 
            // doorlockSettings
            // 
            this.doorlockSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.doorlockSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.doorlockSettings.Location = new System.Drawing.Point(0, 1075);
            this.doorlockSettings.Name = "doorlockSettings";
            this.doorlockSettings.Size = new System.Drawing.Size(0, 800);
            this.doorlockSettings.TabIndex = 13;
            this.doorlockSettings.Visible = false;
            // 
            // lightSettings
            // 
            this.lightSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lightSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lightSettings.Location = new System.Drawing.Point(0, 1875);
            this.lightSettings.Name = "lightSettings";
            this.lightSettings.Size = new System.Drawing.Size(0, 800);
            this.lightSettings.TabIndex = 14;
            this.lightSettings.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lightSettings);
            this.Controls.Add(this.doorlockSettings);
            this.Controls.Add(this.musicSettings);
            this.Controls.Add(this.profileSettings);
            this.Controls.Add(this.flowLayoutPanelNavBar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanelNavBar.ResumeLayout(false);
            this.panelContentBox.ResumeLayout(false);
            this.panelContentBox.PerformLayout();
            this.flowLayoutPanelTopBar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button buttonProfileSettings;
        private System.Windows.Forms.Button buttonMusicSettings;
        private System.Windows.Forms.Button buttonLockSettings;
        private System.Windows.Forms.Button buttonLightSettings;
        private System.Windows.Forms.Button buttonCoffeeSettings;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelLoggedInAs;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelNFC;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelContentBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTopBar;
        private System.Windows.Forms.Panel panelHeader;
        private ProfileSettings profileSettings;
        private System.IO.Ports.SerialPort serialPort;
        private MusicSettings musicSettings;
        private DoorlockSettings doorlockSettings;
        private LightSettings lightSettings;
    }
}


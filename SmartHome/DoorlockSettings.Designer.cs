namespace SmartHome
{
    partial class DoorlockSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoorlockSettings));
            this.panelPadding = new System.Windows.Forms.Panel();
            this.panelDoorlockSettings = new System.Windows.Forms.Panel();
            this.panelSaveButton = new System.Windows.Forms.Panel();
            this.panelDivider2 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelToggleControl = new System.Windows.Forms.Panel();
            this.pictureBoxUnlocked = new System.Windows.Forms.PictureBox();
            this.radioButtonUnlocked = new System.Windows.Forms.RadioButton();
            this.radioButtonLocked = new System.Windows.Forms.RadioButton();
            this.pictureBoxLocked = new System.Windows.Forms.PictureBox();
            this.labelDoorlockSettings = new System.Windows.Forms.Label();
            this.labelDoorlockControl = new System.Windows.Forms.Label();
            this.panelDoorlockSettings.SuspendLayout();
            this.panelSaveButton.SuspendLayout();
            this.panelToggleControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnlocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocked)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPadding
            // 
            this.panelPadding.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPadding.Location = new System.Drawing.Point(0, 0);
            this.panelPadding.Margin = new System.Windows.Forms.Padding(0);
            this.panelPadding.Name = "panelPadding";
            this.panelPadding.Size = new System.Drawing.Size(1920, 50);
            this.panelPadding.TabIndex = 3;
            // 
            // panelDoorlockSettings
            // 
            this.panelDoorlockSettings.Controls.Add(this.panelSaveButton);
            this.panelDoorlockSettings.Controls.Add(this.panelToggleControl);
            this.panelDoorlockSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoorlockSettings.Location = new System.Drawing.Point(0, 50);
            this.panelDoorlockSettings.Name = "panelDoorlockSettings";
            this.panelDoorlockSettings.Size = new System.Drawing.Size(1920, 750);
            this.panelDoorlockSettings.TabIndex = 4;
            // 
            // panelSaveButton
            // 
            this.panelSaveButton.Controls.Add(this.panelDivider2);
            this.panelSaveButton.Controls.Add(this.buttonSave);
            this.panelSaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaveButton.Location = new System.Drawing.Point(0, 600);
            this.panelSaveButton.Name = "panelSaveButton";
            this.panelSaveButton.Size = new System.Drawing.Size(1920, 150);
            this.panelSaveButton.TabIndex = 7;
            // 
            // panelDivider2
            // 
            this.panelDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.panelDivider2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDivider2.Location = new System.Drawing.Point(0, 0);
            this.panelDivider2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelDivider2.Name = "panelDivider2";
            this.panelDivider2.Size = new System.Drawing.Size(1920, 1);
            this.panelDivider2.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonSave.Location = new System.Drawing.Point(100, 60);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(230, 50);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelToggleControl
            // 
            this.panelToggleControl.Controls.Add(this.pictureBoxUnlocked);
            this.panelToggleControl.Controls.Add(this.radioButtonUnlocked);
            this.panelToggleControl.Controls.Add(this.radioButtonLocked);
            this.panelToggleControl.Controls.Add(this.pictureBoxLocked);
            this.panelToggleControl.Controls.Add(this.labelDoorlockSettings);
            this.panelToggleControl.Controls.Add(this.labelDoorlockControl);
            this.panelToggleControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToggleControl.Location = new System.Drawing.Point(0, 0);
            this.panelToggleControl.Name = "panelToggleControl";
            this.panelToggleControl.Size = new System.Drawing.Size(1920, 600);
            this.panelToggleControl.TabIndex = 3;
            // 
            // pictureBoxUnlocked
            // 
            this.pictureBoxUnlocked.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnlocked.Image")));
            this.pictureBoxUnlocked.Location = new System.Drawing.Point(800, 145);
            this.pictureBoxUnlocked.Name = "pictureBoxUnlocked";
            this.pictureBoxUnlocked.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxUnlocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnlocked.TabIndex = 7;
            this.pictureBoxUnlocked.TabStop = false;
            // 
            // radioButtonUnlocked
            // 
            this.radioButtonUnlocked.AutoSize = true;
            this.radioButtonUnlocked.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUnlocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.radioButtonUnlocked.Location = new System.Drawing.Point(925, 105);
            this.radioButtonUnlocked.Name = "radioButtonUnlocked";
            this.radioButtonUnlocked.Size = new System.Drawing.Size(157, 36);
            this.radioButtonUnlocked.TabIndex = 1;
            this.radioButtonUnlocked.TabStop = true;
            this.radioButtonUnlocked.Text = "Unlocked";
            this.radioButtonUnlocked.UseVisualStyleBackColor = true;
            this.radioButtonUnlocked.CheckedChanged += new System.EventHandler(this.LockStateChanged);
            // 
            // radioButtonLocked
            // 
            this.radioButtonLocked.AutoSize = true;
            this.radioButtonLocked.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.radioButtonLocked.Location = new System.Drawing.Point(225, 105);
            this.radioButtonLocked.Name = "radioButtonLocked";
            this.radioButtonLocked.Size = new System.Drawing.Size(129, 36);
            this.radioButtonLocked.TabIndex = 0;
            this.radioButtonLocked.TabStop = true;
            this.radioButtonLocked.Text = "Locked";
            this.radioButtonLocked.UseVisualStyleBackColor = true;
            this.radioButtonLocked.CheckedChanged += new System.EventHandler(this.LockStateChanged);
            // 
            // pictureBoxLocked
            // 
            this.pictureBoxLocked.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLocked.Image")));
            this.pictureBoxLocked.Location = new System.Drawing.Point(100, 145);
            this.pictureBoxLocked.Name = "pictureBoxLocked";
            this.pictureBoxLocked.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxLocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLocked.TabIndex = 4;
            this.pictureBoxLocked.TabStop = false;
            // 
            // labelDoorlockSettings
            // 
            this.labelDoorlockSettings.AutoSize = true;
            this.labelDoorlockSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoorlockSettings.Location = new System.Drawing.Point(100, 10);
            this.labelDoorlockSettings.Name = "labelDoorlockSettings";
            this.labelDoorlockSettings.Size = new System.Drawing.Size(219, 28);
            this.labelDoorlockSettings.TabIndex = 1;
            this.labelDoorlockSettings.Text = "Doorlock Settings";
            // 
            // labelDoorlockControl
            // 
            this.labelDoorlockControl.AutoSize = true;
            this.labelDoorlockControl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoorlockControl.Location = new System.Drawing.Point(100, 60);
            this.labelDoorlockControl.Name = "labelDoorlockControl";
            this.labelDoorlockControl.Size = new System.Drawing.Size(507, 22);
            this.labelDoorlockControl.TabIndex = 3;
            this.labelDoorlockControl.Text = "I want my doors locked/unlocked when i arrive at home";
            // 
            // DoorlockSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panelDoorlockSettings);
            this.Controls.Add(this.panelPadding);
            this.Name = "DoorlockSettings";
            this.Size = new System.Drawing.Size(1920, 800);
            this.VisibleChanged += new System.EventHandler(this.DoorlockSettings_VisibleChanged);
            this.panelDoorlockSettings.ResumeLayout(false);
            this.panelSaveButton.ResumeLayout(false);
            this.panelToggleControl.ResumeLayout(false);
            this.panelToggleControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnlocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocked)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPadding;
        private System.Windows.Forms.Panel panelDoorlockSettings;
        private System.Windows.Forms.Label labelDoorlockSettings;
        private System.Windows.Forms.Panel panelToggleControl;
        private System.Windows.Forms.Label labelDoorlockControl;
        private System.Windows.Forms.Panel panelSaveButton;
        private System.Windows.Forms.Panel panelDivider2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxLocked;
        private System.Windows.Forms.RadioButton radioButtonUnlocked;
        private System.Windows.Forms.RadioButton radioButtonLocked;
        private System.Windows.Forms.PictureBox pictureBoxUnlocked;
    }
}

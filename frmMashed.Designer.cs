namespace SciLor_s_Mashed_Runner {
    partial class frmMashed {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnRunMashed = new System.Windows.Forms.Button();
            this.btnRunVideo = new System.Windows.Forms.Button();
            this.btnRunController = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIntro = new System.Windows.Forms.ComboBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cmbIcon = new System.Windows.Forms.ComboBox();
            this.btnShortcut = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.grpLaunch = new System.Windows.Forms.GroupBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnPatch = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnAccess = new System.Windows.Forms.Button();
            this.grpSettings.SuspendLayout();
            this.grpLaunch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRunMashed
            // 
            this.btnRunMashed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunMashed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRunMashed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunMashed.Location = new System.Drawing.Point(12, 12);
            this.btnRunMashed.Name = "btnRunMashed";
            this.btnRunMashed.Size = new System.Drawing.Size(233, 45);
            this.btnRunMashed.TabIndex = 0;
            this.btnRunMashed.Text = "Run";
            this.btnRunMashed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunMashed.UseVisualStyleBackColor = true;
            this.btnRunMashed.Click += new System.EventHandler(this.btnRunMashed_Click);
            // 
            // btnRunVideo
            // 
            this.btnRunVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunVideo.Location = new System.Drawing.Point(12, 59);
            this.btnRunVideo.Name = "btnRunVideo";
            this.btnRunVideo.Size = new System.Drawing.Size(233, 45);
            this.btnRunVideo.TabIndex = 1;
            this.btnRunVideo.Text = "Video Configuration";
            this.btnRunVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunVideo.UseVisualStyleBackColor = true;
            this.btnRunVideo.Click += new System.EventHandler(this.btnRunVideo_Click);
            // 
            // btnRunController
            // 
            this.btnRunController.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunController.Location = new System.Drawing.Point(12, 106);
            this.btnRunController.Name = "btnRunController";
            this.btnRunController.Size = new System.Drawing.Size(233, 45);
            this.btnRunController.TabIndex = 2;
            this.btnRunController.Text = "Controller Configuration";
            this.btnRunController.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunController.UseVisualStyleBackColor = true;
            this.btnRunController.Click += new System.EventHandler(this.btnRunController_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(232, 386);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(19, 13);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "v5";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.cmbIntro);
            this.grpSettings.Controls.Add(this.lblIcon);
            this.grpSettings.Controls.Add(this.lblPath);
            this.grpSettings.Controls.Add(this.lblLanguage);
            this.grpSettings.Controls.Add(this.cmbIcon);
            this.grpSettings.Controls.Add(this.btnShortcut);
            this.grpSettings.Controls.Add(this.btnPath);
            this.grpSettings.Controls.Add(this.txtPath);
            this.grpSettings.Controls.Add(this.cmbLanguage);
            this.grpSettings.Enabled = false;
            this.grpSettings.Location = new System.Drawing.Point(12, 167);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(233, 161);
            this.grpSettings.TabIndex = 9;
            this.grpSettings.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Intro:";
            // 
            // cmbIntro
            // 
            this.cmbIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIntro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntro.FormattingEnabled = true;
            this.cmbIntro.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.cmbIntro.Location = new System.Drawing.Point(85, 129);
            this.cmbIntro.Name = "cmbIntro";
            this.cmbIntro.Size = new System.Drawing.Size(142, 21);
            this.cmbIntro.Sorted = true;
            this.cmbIntro.TabIndex = 14;
            this.cmbIntro.SelectedIndexChanged += new System.EventHandler(this.cmbIntro_SelectedIndexChanged);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(15, 77);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(64, 13);
            this.lblIcon.TabIndex = 16;
            this.lblIcon.Text = "Select Icon:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 52);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(73, 13);
            this.lblPath.TabIndex = 15;
            this.lblPath.Text = "Mashed Path:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(21, 22);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(58, 13);
            this.lblLanguage.TabIndex = 14;
            this.lblLanguage.Text = "Language:";
            // 
            // cmbIcon
            // 
            this.cmbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIcon.FormattingEnabled = true;
            this.cmbIcon.Location = new System.Drawing.Point(85, 74);
            this.cmbIcon.Name = "cmbIcon";
            this.cmbIcon.Size = new System.Drawing.Size(142, 21);
            this.cmbIcon.Sorted = true;
            this.cmbIcon.TabIndex = 12;
            this.cmbIcon.SelectedIndexChanged += new System.EventHandler(this.cmbIcon_SelectedIndexChanged);
            // 
            // btnShortcut
            // 
            this.btnShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShortcut.Location = new System.Drawing.Point(85, 101);
            this.btnShortcut.Name = "btnShortcut";
            this.btnShortcut.Size = new System.Drawing.Size(142, 22);
            this.btnShortcut.TabIndex = 13;
            this.btnShortcut.Text = "Create Shortcut";
            this.btnShortcut.UseVisualStyleBackColor = true;
            this.btnShortcut.Click += new System.EventHandler(this.btnShortcut_Click);
            // 
            // btnPath
            // 
            this.btnPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath.Location = new System.Drawing.Point(197, 48);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(30, 20);
            this.btnPath.TabIndex = 11;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(85, 49);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(106, 20);
            this.txtPath.TabIndex = 10;
            this.txtPath.TabStop = false;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(85, 19);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(142, 21);
            this.cmbLanguage.Sorted = true;
            this.cmbLanguage.TabIndex = 9;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // grpLaunch
            // 
            this.grpLaunch.Controls.Add(this.btnLaunch);
            this.grpLaunch.Controls.Add(this.btnPatch);
            this.grpLaunch.Controls.Add(this.btnInstall);
            this.grpLaunch.Enabled = false;
            this.grpLaunch.Location = new System.Drawing.Point(12, 334);
            this.grpLaunch.Name = "grpLaunch";
            this.grpLaunch.Size = new System.Drawing.Size(210, 68);
            this.grpLaunch.TabIndex = 10;
            this.grpLaunch.TabStop = false;
            this.grpLaunch.Text = "Original Launcher";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(143, 19);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(60, 40);
            this.btnLaunch.TabIndex = 20;
            this.btnLaunch.Text = "Run Launcher";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnPatch
            // 
            this.btnPatch.Location = new System.Drawing.Point(6, 19);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(50, 40);
            this.btnPatch.TabIndex = 18;
            this.btnPatch.Text = "NoCD Patch";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(62, 19);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 40);
            this.btnInstall.TabIndex = 19;
            this.btnInstall.Text = "Install + Set Language";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAccess.Location = new System.Drawing.Point(20, 159);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(115, 25);
            this.btnAccess.TabIndex = 11;
            this.btnAccess.Text = "Change Settings";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // frmMashed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 408);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.grpLaunch);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnRunController);
            this.Controls.Add(this.btnRunVideo);
            this.Controls.Add(this.btnRunMashed);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMashed";
            this.ShowIcon = false;
            this.Text = "SciLor\'s Mashed Runner";
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpLaunch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunMashed;
        private System.Windows.Forms.Button btnRunVideo;
        private System.Windows.Forms.Button btnRunController;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbIcon;
        private System.Windows.Forms.Button btnShortcut;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIntro;
        internal System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.GroupBox grpLaunch;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnAccess;
    }
}


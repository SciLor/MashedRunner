using System;
using System.Drawing;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;
using System.Diagnostics;

namespace SciLor_s_Mashed_Runner {
    public partial class frmMashed : Form {
        public frmMashed() {
            InitializeComponent();

            setMashedVersion();
            btnRunMashed.Text = Mashed.version.NAME();

            cmbLanguage.SelectedIndexChanged -= new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            cmbIcon.SelectedIndexChanged -= new System.EventHandler(this.cmbIcon_SelectedIndexChanged);


            cmbLanguage.Items.Add(new Language("English", "English", "ENG", 0));
            cmbLanguage.Items.Add(new Language("Français", "French", "FRA", 1));
            cmbLanguage.Items.Add(new Language("Deutsch", "German", "DEU", 2));
            cmbLanguage.Items.Add(new Language("Español", "Spanish", "ESN", 3));
            cmbLanguage.Items.Add(new Language("Italiano", "Italian", "ITA", 4));

            cmbLanguage.SelectedIndex = Properties.Settings.Default.Language;

            if (Properties.Settings.Default.Path.Length == 0) {
                Properties.Settings.Default.Path = Util.GetExeDir() + "\\";
                if (Mashed.checkExe()) {
                    Properties.Settings.Default.Save();
                }
            }
            txtPath.Text = Util.GetMashedDir();
            txtPath.Text += Mashed.version.EXE();

            for (int i = 0; i < Mashed.ICOS.Length; i++) {
                IconFile icon = Mashed.ICOS[i];
                cmbIcon.Items.Add(icon);
            }

            if (Properties.Settings.Default.Icon.Length == 0) {
                Properties.Settings.Default.Icon = Mashed.ICO;
            }
            foreach (Object obj in cmbIcon.Items) {
                if (obj.Equals(new IconFile(Properties.Settings.Default.Icon))) {
                    cmbIcon.SelectedItem = obj;
                }
            }

            loadICO();
            setIntroState();


            cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            cmbIcon.SelectedIndexChanged += new System.EventHandler(this.cmbIcon_SelectedIndexChanged);

            if (Util.IsAnAdministrator()) {
                this.grpLaunch.Enabled = true;
                this.grpSettings.Enabled = true;
                this.btnAccess.Visible = false;
            } else {
                Util.setUAC(btnAccess);
            }
        }

        private void setMashedVersion() {
            Version tmp = new VersionMFL();
            if (!tmp.EXE_EXISTS()) {
                tmp = new VersionMashed();
                if (!tmp.EXE_EXISTS()) {
                    tmp = new VersionMFL();
                }
            }
            Mashed.version = tmp;
        }

        private void btnRunMashed_Click(object sender, EventArgs e) {
            Mashed.Run(false, false, true, this);
        }

        private void btnRunVideo_Click(object sender, EventArgs e) {
            Mashed.Run(true, false, false, this);
        }

        private void btnRunController_Click(object sender, EventArgs e) {
            Mashed.Run(false, true, false, this);
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e) {
            Properties.Settings.Default.Language = cmbLanguage.SelectedIndex;
            Properties.Settings.Default.Save();
        }


        private void btnPath_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            Version mfl = new VersionMFL();
            Version mashed = new VersionMashed();

            ofd.Filter = mfl.EXE() + "/" + mashed.EXE() + "|" + mfl.EXE() + ";"+ mashed.EXE();
            ofd.CheckFileExists = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    txtPath.Text = ofd.FileName;
                    setMashedVersion();
                    Properties.Settings.Default.Path = txtPath.Text.Remove(txtPath.TextLength -System.IO.Path.GetFileName(ofd.FileName).Length);
                    Properties.Settings.Default.Save();
                    //loadICO();
                    //setIntroState();
                    Application.Restart();
            }
        }

        private void btnShortcut_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".lnk";
            sfd.FileName = Mashed.version.NAME()+ ".lnk";
            sfd.Filter = "Shortcut (*.lnk)|*.lnk";
            sfd.ValidateNames = true;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK && sfd.FileName != null) {
                WshShellClass wshShell = new WshShellClass();
                try {
                    IWshShortcut link = (IWshShortcut)(wshShell.CreateShortcut(sfd.FileName));
                    link.TargetPath = Util.GetExePath();
                    link.Arguments = "-fix";
                    link.Description = "Starts "+ Mashed.version.NAME();
                    if (Mashed.checkExe()) 
                        link.IconLocation = Util.GetExeDir() + "\\" +
                            "icon" + cmbIcon.SelectedItem + ".ico";
                    link.Save();

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbIcon_SelectedIndexChanged(object sender, EventArgs e) {
            Properties.Settings.Default.Icon = (cmbIcon.SelectedItem as IconFile).path;
            Properties.Settings.Default.Save();
            loadICO();
        }

        private void cmbIntro_SelectedIndexChanged(object sender, EventArgs e) {
            if ((String)cmbIntro.SelectedItem == "Enabled") {
                Intro.Enable();
            } else {
                Intro.Disable();
            }
            setIntroState();
        }



        private void setIntroState() {
            String path = Properties.Settings.Default.Path + Mashed.BASE_VIDEO_DIR + "backup";
            cmbIntro.SelectedIndexChanged -= new System.EventHandler(this.cmbIntro_SelectedIndexChanged);
            if (!System.IO.Directory.Exists(path)) {
                cmbIntro.SelectedItem = "Enabled";
            } else {
                cmbIntro.SelectedItem = "Disabled";
            }
            cmbIntro.SelectedIndexChanged += new System.EventHandler(this.cmbIntro_SelectedIndexChanged);

        }
        private void loadICO() {
            String path = Util.GetMashedDir() + Properties.Settings.Default.Icon;
            if (!System.IO.File.Exists(path)) {
                return;
            }

            btnRunMashed.Image = new Bitmap(path);
            btnRunVideo.Image = btnRunMashed.Image;
            btnRunController.Image = btnRunMashed.Image;

            btnRunMashed.ImageAlign = ContentAlignment.TopLeft;
            btnRunVideo.ImageAlign = ContentAlignment.MiddleLeft;
            btnRunController.ImageAlign = ContentAlignment.BottomLeft;

            this.ShowIcon = false;
            this.Icon = null;
            this.ShowIcon = true;
            this.Icon = Icon.FromHandle(new Bitmap(path).GetHicon());

            String iconPath = Util.GetExeDir() + "\\" +
                "icon" + cmbIcon.SelectedItem + ".ico";

            if (!System.IO.File.Exists(iconPath)) {
                try {
                    FileStream fs = new FileStream(iconPath, FileMode.Create);
                    this.Icon.Save(fs);
                    fs.Close();
                } catch (Exception) { }
            }
        }

        private void btnPatch_Click(object sender, EventArgs e) {
            if (!Mashed.checkExe()) return;
            if (SearchAndReplace.PatchLauncher(Util.GetMashedDir() + Mashed.version.LAUNCHER(), Mashed.version.NOCD_SEARCH(), Mashed.version.NOCD_REPLACE())) {
                MessageBox.Show("Launch.exe successfully patched.\r\nYou can now run " + Mashed.version.NAME() + " without CD using the original launcher.\r\n\r\nBackup created.");
            } else {
                MessageBox.Show("Launch.exe not patched.\r\nMaybe you already installed the patch.\r\n(You can delete the backup file Launch.exe.bak, if you want to try again.)");
            }
        }

        private void btnInstall_Click(object sender, EventArgs e) {
            if (!Mashed.checkExe()) return;
            Mashed.setRegistryLanguage((Language)cmbLanguage.SelectedItem);
            Mashed.setRegistryInstallation(Util.GetMashedDir());
        }

        private void btnLaunch_Click(object sender, EventArgs e) {
            if (!Mashed.checkExe()) return;
            Process.Start(Util.GetMashedDir() + Mashed.version.LAUNCHER());

                this.Close();
                Application.Exit();
        }

        private void btnAccess_Click(object sender, EventArgs e) {
            try {
                Process p = new Process();
                p.StartInfo.FileName = Application.ExecutablePath;
                //Vista or higher check
                if (System.Environment.OSVersion.Version.Major >= 6) {
                    p.StartInfo.Verb = "runas";
                }
                p.Start();
                this.Close();
                Application.Exit();
            } catch (Exception) { }
        }
    }
}

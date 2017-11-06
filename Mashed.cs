using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Security.Permissions;
using System.Security;

namespace SciLor_s_Mashed_Runner {
    class Mashed {

        public static Version version = null;

        [DllImport("user32.dll")]
        private static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        public const String EMPTY_VIDEO = "SciLorsEmptyVideo.mpg";
        public const String BASE_VIDEO_DIR = @"TOASTART\PC\MOVIES\";
        public static String[] VIDEO_NAMES = { 
                                                  "empire.mpg",
                                                  "intro.mpg",
                                                  "renderware.mpg",
                                                  "small.mpg",
                                                  "supersonic.mpg"
                                              };

        public const String SAVE = ""; //@"save\";

        public static IconFile[] ICOS = {
            new IconFile(@"TOASTART\Common\PANEL\NFLRed.png"),
            new IconFile(@"TOASTART\Common\PANEL\NFLBluejay.png"),
            new IconFile(@"TOASTART\Common\PANEL\NFLGold.png"),
            new IconFile(@"TOASTART\Common\PANEL\NFLMelon.png"),
            new IconFile(@"TOASTART\Common\PANEL\NFLPink.png"),
            new IconFile(@"TOASTART\Common\PANEL\NFLShadow.png"),
                                              };

        public const String ICO = @"TOASTART\Common\PANEL\NFLRed.png";
        public const String ICO_SMALL = "mashed.ICO";
       
        public static void Run(bool video, bool control, bool exit, frmMashed form) { //-VS0 -CS0 -L1
            if (!checkExe()) return;
            form.Enabled = false;
            //form.WindowState = FormWindowState.Minimized;

            int lang = 0;
            if (form.cmbLanguage.SelectedItem != null) {
                Language langObj = (Language)form.cmbLanguage.SelectedItem;
                lang = langObj.Id;
            }

            Process p = new Process();
            p.StartInfo.FileName = Properties.Settings.Default.Path + version.EXE();
            p.StartInfo.Arguments = "-VS" + bool2int(video) + " " + "-CS" + bool2int(control) + " " + "-L" + lang;
            p.StartInfo.WorkingDirectory = Properties.Settings.Default.Path + Mashed.SAVE;
            p.Start();

            if (exit) {
                form.Close();
                Application.Exit();
            } else {
                p.WaitForExit();
                form.Enabled = true;
                form.Refresh();
                if (form.WindowState != FormWindowState.Minimized) 
                    form.WindowState = FormWindowState.Minimized;
                //form.WindowState = FormWindowState.Normal;
                SwitchToThisWindow(form.Handle, true);
                form.Show();

            }
        }
        private static int bool2int(bool value) {
            if (value) return 1;
            return 0;
        }

        private static RegistryKey getRegistryBase(String subkey) {
            RegistryKey baseKey = Registry.LocalMachine.OpenSubKey("Software", true);
            return baseKey.CreateSubKey(version.REGISTRY_BASE()).CreateSubKey(subkey);
        }
        private static bool setRegistryInstallation(String path, RegistryKey key) {
            try {
                key.DeleteValue("installpath", false);
                key.SetValue("installpath", path, RegistryValueKind.String);
                key.DeleteValue("installstatus", false);
                key.SetValue("installstatus", "2", RegistryValueKind.String);

                key.Close();
                return true;
            } catch (SecurityException) {}
            return false;
        }
        public static bool setRegistryInstallation(String path) {
            bool fine = false;
            fine = setRegistryInstallation(path, getRegistryBase(version.REGISTRY_SUBKEY()));
            return fine;
        }
        public static bool setRegistryLanguage(Language lang, RegistryKey key) {
            try {
                key.SetValue("language", lang.Identifier, RegistryValueKind.String);
                key.Close();
            } catch (SecurityException) { }
            return false;
        }
        public static bool setRegistryLanguage(Language lang) {
            bool fine = false;
            fine = setRegistryLanguage(lang, getRegistryBase(version.REGISTRY_SUBKEY()));
            return fine;
        }

        public static bool checkExe() {
            if (!System.IO.File.Exists(Util.GetMashedDir() + version.EXE())) {
                MessageBox.Show(version.EXE() + " " + "not found" + "\r\n" +
                    "Please copy this application into the " + version.NAME() + " directory" + "\r\n" +
                    "or select the right path to its executable.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

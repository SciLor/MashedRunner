using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SciLor_s_Mashed_Runner {
    class Util {
        [DllImport("user32")]
        public static extern UInt32 SendMessage(IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam);
        private const uint BCM_SETSHIELD = 0x0000160C;

        public static String GetExePath() {
            String path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            if (path.StartsWith("file:///")) {
                path = path.Substring("file:///".Length);
            }
            path = path.Replace('/', '\\');
            return path;
        }
        public static String GetExeDir() {
            return Path.GetDirectoryName(GetExePath());
        }
        public static String GetMashedDir() {
            return Properties.Settings.Default.Path;
        }
        public static bool IsAnAdministrator() {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public static void setUAC(Button btn) {
            btn.FlatStyle = FlatStyle.System;
            SendMessage(btn.Handle, BCM_SETSHIELD, 0, 1);
        }

    }
}

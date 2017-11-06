using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace SciLor_s_Mashed_Runner {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args) {
            /*
            if (args.Length == 1) {
                if (args[0] == "-fix") {
                    Process.Start(Application.ExecutablePath);
                    Application.Exit();
                    return;
                } else if (args[0] == "-registry") {
                    frmMashed.setRegistry = true;
                }
            }
             * */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMashed());
        }
    }
}

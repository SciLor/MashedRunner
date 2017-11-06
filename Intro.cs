using System;
using System.IO;
using System.Reflection;

namespace SciLor_s_Mashed_Runner {
    class Intro {
        public static void Enable() {
            String path = Properties.Settings.Default.Path + Mashed.BASE_VIDEO_DIR;
            if (!Directory.Exists(path) || !Directory.Exists(path + "backup")) {
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo file in dir.GetFiles()) {
                String tmp = path + "backup" + "\\" + file.Name;
                if (System.IO.File.Exists(tmp)) {
                    file.Delete();
                    System.IO.File.Move(tmp, file.FullName);
                }
            }
            Directory.Delete(path + "backup", true);
        }

        public static void Disable() {
            String path = Properties.Settings.Default.Path + Mashed.BASE_VIDEO_DIR;
            if (!Directory.Exists(path)) {
                return;
            }

            Stream resStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(
                "SciLor_s_Mashed_Runner.tmp.SciLorsEmptyVideo.mpg");
            FileStream fileStream = new FileStream(Path.GetDirectoryName(Util.GetExePath()) + "\\" + Mashed.EMPTY_VIDEO,
                FileMode.Create);

            int read = 1;
            byte[] buffer = new byte[1024];
            while (read > 0) {
                read = resStream.Read(buffer, 0, buffer.Length);
                fileStream.Write(buffer, 0, read);
            }

            resStream.Close();
            fileStream.Flush();
            fileStream.Close();

            if (!Directory.Exists(path + "backup"))
                Directory.CreateDirectory(path + "backup");

            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo file in dir.GetFiles()) {
                bool active = false;
                foreach (String allowed in Mashed.VIDEO_NAMES) {
                    if (file.Name == allowed) {
                        active = true;
                        break;
                    }
                }
                if (!active) continue;

                String tmp = path + "backup" + "\\" + file.Name;
                String old = file.FullName;

                if (System.IO.File.Exists(tmp))
                    System.IO.File.Delete(tmp);
                file.MoveTo(tmp);
                System.IO.File.Copy(Path.GetDirectoryName(Util.GetExePath()) + "\\" + Mashed.EMPTY_VIDEO, old);
            }

            System.IO.File.Delete(Path.GetDirectoryName(Util.GetExePath()) + "\\" + Mashed.EMPTY_VIDEO);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SciLor_s_Mashed_Runner {
    public class IconFile {
        public String path;
        public IconFile(String path) {
            this.path = path;
        }
        public override string ToString() {
            string filename = Path.GetFileNameWithoutExtension(path);
            filename = filename.Substring(3);
            return filename;
        }
        public override bool Equals(object obj) {
            if (!(obj is IconFile)) return false;
            IconFile icon = (IconFile)obj;
            if (icon.path != this.path) return false;
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SciLor_s_Mashed_Runner {
    public class VersionMashed : VersionMFL {
        public override string NAME() {
            return "Mashed";
        }
        public override string EXE() {
            return "Mashed.exe";
        }
        public override string REGISTRY_SUBKEY() {
            return "Mashed";
        }
    }
}

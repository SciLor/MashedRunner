using System;
using System.Collections.Generic;
using System.Text;

namespace SciLor_s_Mashed_Runner {
    public abstract class Version {
        public abstract string NAME();
        public abstract string EXE();
        public abstract string LAUNCHER();
        public abstract string REGISTRY_BASE();
        public abstract string REGISTRY_SUBKEY();

        public abstract ByteMask[] NOCD_SEARCH();
        public abstract ByteMask[] NOCD_REPLACE();

        public bool EXE_EXISTS() {
            return System.IO.File.Exists(Util.GetMashedDir() + EXE());
        }
    }
}

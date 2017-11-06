using System;
using System.Collections.Generic;
using System.Text;

namespace SciLor_s_Mashed_Runner {
    public class VersionMFL : Version {

        public override string NAME() {
            return "Mashed Fully Loaded";
        }

        public override string EXE() {
            return "MFL.exe";
        }

        public override string LAUNCHER() {
            return "launch.exe";
        }

        public override string REGISTRY_BASE() {
            return "empire interactive";
        }

        public override string REGISTRY_SUBKEY() {
            return "mfl";
        }

        public override ByteMask[] NOCD_SEARCH() {
            return new ByteMask[] {
                new ByteMask("FF 90 0C 07 00 00 3B C3 7D 12 68 0C 07 00 00 68 ?? 43 4E 00 56 50 FF 15 50 10 40 00 83 C8 FF 66"), //Messagebox 
                new ByteMask("0F 85 54 02 00 00 8B 17 8B 3D 40 10 40 00 52 68 ?? 49 4E 00 66 89 86 A8 00 00 00 FF D7 8B D0 8D"), //Do not run
                                   };
        }

        public override ByteMask[] NOCD_REPLACE() {
            return new ByteMask[] {
                new ByteMask("90 ?? 90 90 90 90 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ??"), //NOP it out ;)
                new ByteMask("EB 04 90 90 90 90 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ??"), //JMP always :P
                                   };
        }
    }
}

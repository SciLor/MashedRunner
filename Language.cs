using System;
using System.Collections.Generic;
using System.Text;

namespace SciLor_s_Mashed_Runner {
    public class Language {
        private String name;
        private String nameEnglish;

        private int id;
        public int Id {
            get { return id; }
        }
        private String identifier;
        public String Identifier {
            get { return identifier; }
        }

        public Language(String name, String nameEnglish, String identifier, int id) {
            this.name = name;
            this.nameEnglish = nameEnglish;
            this.id = id;
            this.identifier = identifier;
        }

        public override string ToString() {
            return name + " (" + nameEnglish + ")";
        }
    }
}

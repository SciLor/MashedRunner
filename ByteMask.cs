using System;
using System.Collections.Generic;
using System.Text;

namespace SciLor_s_Mashed_Runner {
    public class ByteMask {
        private byte[] pattern;
        public byte[] Pattern {
            get { return pattern; }
        }
        private bool[] mask;
        public bool[] Mask {
            get { return mask; }
        }

        private String maskString;
        private string p;

        public ByteMask(String maskString) {
            this.maskString = maskString;
            this.pattern = stringToPattern(maskString);
            this.mask = stringToMask(maskString);
        }

        private byte[] stringToPattern(String pattern) {
            String[] byteText = pattern.Split(' ');
            byte[] bytes = new byte[byteText.Length];

            for (int i = 0; i < byteText.Length; i++) {
                String text = byteText[i];
                if (text != "??") {
                    bytes[i] = byte.Parse(text, System.Globalization.NumberStyles.HexNumber);
                } else {
                    bytes[i] = 0;
                }
            }
            return bytes;
        }
        private bool[] stringToMask(String pattern) {
            String[] byteText = pattern.Split(' ');
            bool[] bytes = new bool[byteText.Length];

            for (int i = 0; i < byteText.Length; i++) {
                String text = byteText[i];
                if (text != "??") {
                    bytes[i] = true;
                } else {
                    bytes[i] = false;
                }
            }
            return bytes;
        }

        public int Length() {
            return this.pattern.Length;
        }
    }
}

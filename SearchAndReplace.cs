using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace SciLor_s_Mashed_Runner {

    class SearchAndReplace {

        public static bool SearchNReplace(String file, ByteMask[] searchPattern, ByteMask[] replacePattern) {
            bool patched = false;
            if (File.Exists(file + ".bak") || File.Exists(file + ".tmp")) return false;
            if (searchPattern.Length != replacePattern.Length) return false;

            int length = 0;
            foreach (ByteMask byteMask in searchPattern) {
                length = Math.Max(length, byteMask.Length());
            }


            File.Copy(file, file + ".bak");
            File.Delete(file);

            FileStream fread = File.OpenRead(file + ".bak");
            if (fread.Length < length) {
                fread.Close();
                File.Copy(file + ".bak", file);
                File.Delete(file + ".bak");
                return false;
            }
            FileStream fwrite = File.OpenWrite(file + ".tmp");

            byte[] buffer = new byte[length];

            int filled = 0;
            while (filled < buffer.Length) {
                buffer[filled] = (byte)fread.ReadByte();
                filled++;
            }

            while (fread.Position < fread.Length) {
                patched = replacePatterns(ref buffer, searchPattern, replacePattern) || patched;
                fwrite.WriteByte(buffer[0]);
                buffer = moveOne(buffer);
                buffer[buffer.Length - 1] = (byte)fread.ReadByte();
            }
            fread.Close();
            patched = replacePatterns(ref buffer, searchPattern, replacePattern) || patched;

            for (int i = 0; i<buffer.Length; i++) {
                fwrite.WriteByte(buffer[i]);
            }
            fwrite.Close();

            File.Copy(file + ".tmp", file);
            File.Delete(file + ".tmp");
            return patched;
        }

        private static bool isSame(byte[] buffer, ByteMask search) {
            for (int i=0; i<search.Length(); i++) {
                if (!search.Mask[i]) continue;
                if (buffer[i] != search.Pattern[i]) return false;
            }
            return true;
        }
        private static byte[] replaceBuffer(byte[] buffer, ByteMask replace) {
            byte[] replacedBuffer = new byte[buffer.Length];
            for (int i=0; i<replace.Length(); i++) {
                if (replace.Mask[i]) {
                    replacedBuffer[i] = replace.Pattern[i];
                } else {
                    replacedBuffer[i] = buffer[i];
                }
            }
            return replacedBuffer;
        }
        private static bool replacePatterns(ref byte[] buffer, ByteMask[] search, ByteMask[] replace) {
            for (int i = 0; i < search.Length; i++) {
                if (isSame(buffer, search[i])) {
                    buffer = replaceBuffer(buffer, replace[i]);
                    return true;
                }
            }
            return false;
        }

        private static byte[] moveOne(byte[] buffer) {
            byte[] tmp = new byte[buffer.Length];
            for (int i = 1; i < buffer.Length; i++) {
                tmp[i - 1] = buffer[i];
            }
            return tmp;
        }

        public static bool PatchLauncher(String path, ByteMask[] search, ByteMask[] replace) {
            return SearchNReplace(path,
                    search,
                    replace);
        }
        public static void RevertLauncher(String path) {
            File.Copy(path + ".bak", path);
            File.Delete(path + ".bak");
        }
    }
}

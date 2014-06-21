using System.Collections.Generic;

namespace David.Patcher.Source_files
{
    class Globals
    {
        public static string ServerURL      = "http://yoursite.com/patch/";
        public static string PatchlistName  = "patchlist.txt";
        public static string BinaryName     = "binary.bin";

        public static pForm pForm;

        public static List<File>    Files    = new List<File>();
        public static List<string>  OldFiles = new List<string>();

        public static long FullSize;
        public static long CompleteSize;

        public struct File
        {
            public string Name;
            public string Hash;
            public long   Size;
        }
    }
}

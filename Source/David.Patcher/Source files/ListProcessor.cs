using System;

namespace David.Patcher.Source_files
{
    class ListProcessor
    {
        public static void AddFile(string File)
        {
            Globals.File file = new Globals.File();

            file.Name = File.Split(' ')[0];
            file.Hash = File.Split(' ')[1];
            file.Size = Convert.ToInt64(File.Split(' ')[2]);

            Globals.Files.Add(file);
        }
    }
}

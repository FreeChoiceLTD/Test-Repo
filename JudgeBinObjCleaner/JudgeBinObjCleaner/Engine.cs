namespace RecycleBinObj
{
    using System;
    using System.IO;
    using System.Linq;

    public class Engine
    {
        private readonly string[] TargetFolders = new[] { "bin", "obj" };

        public void Run()
        {
            var startDirectory = "../../Recycler";
            this.RemoveFolders(startDirectory);
        }

        private void RemoveFolders(string startDirectory)
        {
            var dirs = Directory.GetDirectories(startDirectory);
            for (int i = 0; i < dirs.Length; i++)
            {
                var nameIndex = dirs[i].LastIndexOf('\\');
                if (nameIndex < 0)
                {
                    nameIndex = dirs[i].LastIndexOf('/');
                }

                if (nameIndex < 0)
                {
                    nameIndex = 0;
                }

                var folderName = dirs[i]
                    .Substring(nameIndex)
                    .Trim('/', '\\');

                if (TargetFolders.Any(name => name.EndsWith(folderName, StringComparison.OrdinalIgnoreCase) ||
                    name.EndsWith(folderName, StringComparison.OrdinalIgnoreCase)))
                {
                    this.RemoveDirectory(dirs[i]);
                }
                else
                {
                    this.RemoveFolders(dirs[i]);
                }
            }
        }

        public void RemoveDirectory(string dir)
        {
            var files = Directory.GetFiles(dir);
            for (int i = 0; i < files.Length; i++)
            {
                File.Delete(files[i]);
            }

            var dirs = Directory.GetDirectories(dir);
            for (int i = 0; i < dirs.Length; i++)
            {
                this.RemoveDirectory(dirs[i]);
            }

            Directory.Delete(dir);
        }
    }
}
namespace Delete_File_Type
{
    using System;
    using System.IO;
    using System.Linq;

    public class Engine
    {
        private int deletedFiles;

        public void Run()
        {
            var directory = string.Empty;

            while (true)
            {
                Console.WriteLine("Enter Directory path in which would like to delete: ");
                directory = Console.ReadLine();

                if (Directory.Exists(directory))
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine($"Wrong path: {directory} - Folder does NOT exists");
            }

            Console.WriteLine("Enter extension of the files to be DELETED: ");
            var extension = $".{Console.ReadLine().Trim('.')}";

            this.RemoveFilesByExtension(directory, extension);
            Console.WriteLine($"Ready: {this.deletedFiles} was deleted");
        }

        private void RemoveFilesByExtension(string directory, string extension)
        {
            var dirs = Directory.GetDirectories(directory);
            foreach (var dir in dirs)
            {
                this.RemoveFilesByExtension(dir, extension);
            }

            var filesToDelete = Directory.GetFiles(directory)
                .Where(f => Path
                    .GetExtension(f)
                    .Equals(extension, StringComparison.OrdinalIgnoreCase))
                .ToArray();

            this.deletedFiles += filesToDelete.Length;

            foreach (var file in filesToDelete.Where(f => Path
                .GetExtension(f)
                .Equals(extension, StringComparison.OrdinalIgnoreCase)))
            {
                File.Delete(file);
            }
        }
    }
}

using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

namespace SeekAndArchive
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var fileinfo = new FileInfo("Adam.");
            if (args.Length != 2)
            {
                Console.WriteLine("Fuck you very much");
            }
            else
            {
                string directory = args[0];
                string file = args[1];

                var filesPaths = Directory.GetFiles(directory, file, SearchOption.AllDirectories);

                foreach (var path in filesPaths)
                {
                    Console.WriteLine(path);
                }
                
                
                #region watcher
                var watcher = new FileSystemWatcher {Path = directory};
                
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName |
                                       NotifyFilters.DirectoryName;

                watcher.Filter = "*.txt";
                
                watcher.Changed += OnChanged;
                watcher.Renamed += OnRenamed;

                watcher.EnableRaisingEvents = true;
                
                #endregion
                
                Console.WriteLine("Press \'q\' to quit the sample.");
                while(Console.Read()!='q');
            }
            
            
            
        }
        
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " +  e.FullPath + " " + e.ChangeType);
        }
        
        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
}
using System;
using System.IO;

namespace SeekAndArchive
{
    internal class Program
    {
        public static void Main(string[] args)
        {
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
            }
        }
    }
}
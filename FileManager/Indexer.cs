using System;
using System.Collections.Generic;
using System.IO;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryAdv structure = new DirectoryAdv(@"C:\",0);
            GetAllElements(structure);
            GetAllDirInfo(structure);
        }

        static void GetAllElements(DirectoryAdv structure)
        {
            var direcories = Directory.GetDirectories(structure.Path);
            var files = Directory.GetFiles(structure.Path);

            foreach (var d in direcories) structure.Directories.Add(new DirectoryAdv(d,structure.Level+1));
            foreach (var f in files) structure.Files.Add(new FileInfo(f));
            foreach (var d in structure.Directories)
            {
                try
                {
                    GetAllElements(d);
                }
                catch (Exception e) { }
            }
        }
        
        static void GetAllDirInfo(DirectoryAdv structure)
        {
            structure.Info = new DirectoryInfo(structure.Path);
            GetDirSize(structure);
            foreach (var d in structure.Directories)
            {
                GetAllDirInfo(d);
            }
        }

        static void GetDirSize(DirectoryAdv structure)
        {
            foreach (var f in structure.Files)
            {
                try
                {
                    structure.Size += (double)Math.Round((decimal)f.Length / 1073741824, 2);
                }
                catch { }
            }
        }
        static void PrintTree(DirectoryAdv structure,double PrintSizeMin)
        {
            if(structure.Size >= PrintSizeMin)
            {
                String print = String.Empty;
                for (int i = 0; i < structure.Level; i++) if (structure.Level != 0) print += "\t";
                print += $"{structure.Path} : {structure.Size}";
                Console.WriteLine(print);
            }

            foreach (var d in structure.Directories) PrintTree(d, PrintSizeMin);
        }
        
    }

    public class DirectoryAdv
    {
        public DirectoryAdv(string path, int level)
        {
            Level = level;
            Path = path;
        }
        public int Level { get; private set; }
        public double Size { get; set; }
        public string Path { get; set; }
        public DirectoryInfo Info { get; set; }
        public List<DirectoryAdv> Directories { get; set; } = new List<DirectoryAdv>();
        public List<FileInfo> Files { get; set; } = new List<FileInfo>();
    }
}

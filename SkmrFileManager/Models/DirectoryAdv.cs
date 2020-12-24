using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkmrFileManager
{
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

        public void GetAllElements(IProgress<int> progress)
        {
            var directories = Directory.GetDirectories(Path);
            var files = Directory.GetFiles(Path);
            for(int i = 0; i < directories.Length; i++)
            {
                Directories.Add(new DirectoryAdv(directories[i], Level + 1));
                progress.Report((i + 1) * 100 / directories.Length);
            }

            for (int i = 0; i < files.Length; i++)
            {
                Files.Add(new FileInfo(files[i]));
                progress.Report((i + 1) * 100 / files.Length);
            }
            for(int i = 0; i < Directories.Count; i ++)
            {
                try
                {
                    Directories[i].GetAllElements(progress);
                }
                catch (Exception e) { }
                progress.Report((i + 1) * 100 / directories.Length);
            }
        }

        public void GetDirInfoRek(IProgress<int> progress)
        {
            Info = new DirectoryInfo(Path);
            GetDirSize();
            for(int i = 0; i < Directories.Count; i++)
            {
                Directories[i].GetDirInfoRek(progress);
                progress.Report((i + 1) * 100 / Directories.Count);
            }
        }

        public void GetDirSize()
        {
            foreach (var f in Files)
            {
                try
                {
                    Size += (double)Math.Round((decimal)f.Length / 1073741824, 2);
                }
                catch { }
            }
        }

        public DirectoryAdv[] ToArray()
        {
            List<DirectoryAdv> list = new List<DirectoryAdv>();
            list.Add(this);
            foreach (var d in Directories) d.ToArray(list);
            return list.ToArray();
        }
        private void ToArray(List<DirectoryAdv> list)
        {
            list.Add(this);
            foreach (var d in Directories) d.ToArray(list);
        }
    }
}


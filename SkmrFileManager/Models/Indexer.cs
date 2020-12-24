using SkmrFileManager;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileManager
{
    public class Indexer
    {
        public static DirectoryAdv[] Filter(DirectoryAdv[] structure, double minGbSize = 1.0)
        {
            List<DirectoryAdv> list = new List<DirectoryAdv>();
            foreach (var d in structure)
            {
                if (minGbSize > d.Size) continue;
                list.Add(d);
            }
            return list.ToArray();
        }

        public static StructureInfo GetInfo(DirectoryAdv[] structure)
        {
            StructureInfo result = new StructureInfo();

            result.FolderCount = structure.Length;

            foreach (var e in structure)
            {
                if (e.Level > result.MaxLevel) result.MaxLevel = e.Level;
                result.FileCount += e.Files.Count;
                result.Size += e.Size;
            }

            return result;
        }
    }
}

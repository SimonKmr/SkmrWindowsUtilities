using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkmrFileManager
{
    public class Drives
    {
        public static DriveInfo[] GetDrives()
        {
            return DriveInfo.GetDrives();
        }
        public static string[] GetDriveNames()
        {
            var drives = DriveInfo.GetDrives();
            string[] names = new string[drives.Length];
            for (int i = 0; i < drives.Length; i++) names[i] = drives[i].Name;
            return names;
        }
    }
}

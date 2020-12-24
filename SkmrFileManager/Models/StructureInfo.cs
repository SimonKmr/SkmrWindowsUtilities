namespace FileManager
{
    public class StructureInfo
    {
        public int FolderCount { get; internal set; }
        public int FileCount { get; internal set; }
        public int MaxLevel { get; internal set; }
        public double Size { get; internal set; }
    }
}
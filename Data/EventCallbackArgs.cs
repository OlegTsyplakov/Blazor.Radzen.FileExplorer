namespace B.Data
{
    public class EventCallbackArgs
    {
        public TypeEnums Type { get; set; }
        public string Path { get; set; }
        public string Content { get; set; }
        public bool IsDirectory { get; set; }
        public FileAttributes Attributes { get; set; }
    }
}
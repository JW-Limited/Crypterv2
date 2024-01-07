namespace LILO_Packager.v2.Forms
{
    public class FileDropDialogPreferences
    {
        public Action<string> FileAccepted { get; set; } = null;
        public string TaskName { get; set; } = "n/a";
        public string TaskDescription { get; set; } = "n/a";
        public FileFilter Filter { get; set; } = null;

        public FileDropDialogPreferences()
        {
        }

        public class FileFilter()
        {
            public bool Enabled { get; set; }
            public List<string> Extensions { get; set; }
        }
    }
}

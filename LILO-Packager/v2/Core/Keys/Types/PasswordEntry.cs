namespace LILO_Packager.v2.Core.Keys.Types
{
    public class PasswordEntry
    {
        public PasswordEntry() 
        {
            Id = 0;
            Source = "n/a";
            Password = "Unknown";
        }

        public PasswordEntry(int id, string password, string source)
        {
            Id = id;
            DateAdded = DateTime.Now;
            Source = source ?? throw new ArgumentNullException(nameof(source));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public DateTime DateAdded { get; set; }
        public string Source { get; set; }
    }
}

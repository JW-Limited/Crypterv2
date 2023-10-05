
namespace LILO_Packager.v2.Core.Keys.Types
{
    public interface IPasswordRepository
    {
        string ConnectionString { get; }

        Task DeletePasswordEntryAsync(int id);
        Task<List<PasswordEntry>> GetAllPasswordEntriesAsync();
        Task InitializeDatabaseAsync(Action<string> progressCallback);
        Task InsertPasswordEntryAsync(string password, DateTime dateAdded, string source);
        Task UpdatePasswordEntryAsync(PasswordEntry passwordEntry);
        Task<PasswordEntry> GetPasswordEntryAsync(int id);
    }
}
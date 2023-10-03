using LILO_Packager.v2.Core.Keys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Interfaces
{
    public interface IDatabaseHandler
    {
        Task InitializeDatabaseAsync(Action<string> progressCallback);
        Task InsertPasswordEntryAsync(string password, DateTime dateAdded, string source);
        Task<List<PasswordEntry>> GetAllPasswordEntriesAsync();
    }
}

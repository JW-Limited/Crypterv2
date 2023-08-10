using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Interfaces
{
    public interface IPlaylistDatabase
    {
        Task InitializeDatabaseAsync(Action<string> progressCallback);
        Task InsertSongAsync(string titleInsert, string artist, string place, string id);
        Task ShowPlaylistAsync(Action<string> displayCallback);
    }
}

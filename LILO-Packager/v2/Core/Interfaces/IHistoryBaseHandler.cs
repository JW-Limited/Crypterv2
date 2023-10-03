using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Core.Keys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Interfaces
{
    public interface IHistoryBaseHandler
    {
        Task InitializeDatabaseAsync(Action<string> progressCallback);
        Task InsertEncryptedOperationAsync(string operationType, string mode, string algorithmVersion, string inputFileName, string outputFileName, string id);
        Task UpdateEncryptedOperationAsync(int id, string operationType, string mode, string algorithmVersion, string inputFileName, string outputFileName);
        Task<List<HistoryElement>> GetAllEncryptedOperationsAsync();
        Task<IQueryable<HistoryElement>> GetAllOperationsAsQuery();
    }
}
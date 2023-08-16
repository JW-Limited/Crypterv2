using LILO_Packager.v2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.History
{
    public class DatabaseHandling : IHistoryBaseHandler
    {
        public string ConnectionString => $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "encrypted_operations.db")};Version=3;";

        public async Task InitializeDatabaseAsync(Action<string> progressCallback)
        {
            string databaseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "encrypted_operations.db");

            if (!File.Exists(databaseFilePath))
            {
                SQLiteConnection.CreateFile(databaseFilePath);
                progressCallback?.Invoke("Encrypted operations database created.");

                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    await connection.OpenAsync();

                    string createTableSql = "CREATE TABLE EncryptedOperations (Id INT, OperationType TEXT, Mode TEXT, AlgorithmVersion TEXT, InputFileName TEXT, OutputFileName TEXT)";
                    using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection))
                    {
                        await createTableCommand.ExecuteNonQueryAsync();
                    }

                    progressCallback?.Invoke("Table created.");
                }
            }
        }

        public async Task InsertEncryptedOperationAsync(string operationType, string mode, string algorithmVersion, string inputFileName, string outputFileName, string id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                await connection.OpenAsync();

                string insertSql = "INSERT INTO EncryptedOperations (Id, OperationType, Mode, AlgorithmVersion, InputFileName, OutputFileName) VALUES (@id, @operationType, @mode, @algorithmVersion, @inputFileName, @outputFileName)";
                using (SQLiteCommand insertRowCommand = new SQLiteCommand(insertSql, connection))
                {
                    insertRowCommand.Parameters.AddWithValue("@id", id);
                    insertRowCommand.Parameters.AddWithValue("@operationType", operationType);
                    insertRowCommand.Parameters.AddWithValue("@mode", mode);
                    insertRowCommand.Parameters.AddWithValue("@algorithmVersion", algorithmVersion);
                    insertRowCommand.Parameters.AddWithValue("@inputFileName", inputFileName);
                    insertRowCommand.Parameters.AddWithValue("@outputFileName", outputFileName);

                    await insertRowCommand.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateEncryptedOperationAsync(int id, string operationType, string mode, string algorithmVersion, string inputFileName, string outputFileName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                await connection.OpenAsync();

                string updateSql = "UPDATE EncryptedOperations SET OperationType = @operationType, Mode = @mode, AlgorithmVersion = @algorithmVersion, InputFileName = @inputFileName, OutputFileName = @outputFileName WHERE Id = @id";
                using (SQLiteCommand updateRowCommand = new SQLiteCommand(updateSql, connection))
                {
                    updateRowCommand.Parameters.AddWithValue("@id", id);
                    updateRowCommand.Parameters.AddWithValue("@operationType", operationType);
                    updateRowCommand.Parameters.AddWithValue("@mode", mode);
                    updateRowCommand.Parameters.AddWithValue("@algorithmVersion", algorithmVersion);
                    updateRowCommand.Parameters.AddWithValue("@inputFileName", inputFileName);
                    updateRowCommand.Parameters.AddWithValue("@outputFileName", outputFileName);

                    await updateRowCommand.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task<List<HistoryElement>> GetAllEncryptedOperationsAsync()
        {
            List<HistoryElement> historyElements = new List<HistoryElement>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                await connection.OpenAsync();

                string selectSql = "SELECT * FROM EncryptedOperations";
                using (SQLiteCommand selectRowsCommand = new SQLiteCommand(selectSql, connection))
                using (SQLiteDataReader reader = (SQLiteDataReader)await selectRowsCommand.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        HistoryElement historyElement = new HistoryElement
                        {
                            id = reader.GetInt32(0),
                            operationType = reader.GetString(1),
                            mode = reader.GetString(2),
                            algorithmVersion = reader.GetString(3),
                            inputFileName = reader.GetString(4),
                            outputFileName = reader.GetString(5)
                        };
                        historyElements.Add(historyElement);
                    }
                }
            }

            return historyElements;
        }

        public async Task<IQueryable<HistoryElement>> GetAllOperationsAsQuery()
        {
            List<HistoryElement> historyElements = new List<HistoryElement>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                await connection.OpenAsync();

                string selectSql = "SELECT * FROM EncryptedOperations";
                using (SQLiteCommand selectRowsCommand = new SQLiteCommand(selectSql, connection))
                using (SQLiteDataReader reader = (SQLiteDataReader)await selectRowsCommand.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        HistoryElement historyElement = new HistoryElement
                        {
                            id = reader.GetInt32(0),
                            operationType = reader.GetString(1),
                            mode = reader.GetString(2),
                            algorithmVersion = reader.GetString(3),
                            inputFileName = reader.GetString(4),
                            outputFileName = reader.GetString(5)
                        };
                        historyElements.Add(historyElement);
                    }
                }
            }

            return historyElements.AsQueryable();
        }
    }
}


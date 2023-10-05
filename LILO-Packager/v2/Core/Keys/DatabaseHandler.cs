using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Core.Keys.Types;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Keys
{
    public class DatabaseHandler : IPasswordRepository
    {
        public string ConnectionString => $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "password_history.db")};Version=3;";

        public async Task InitializeDatabaseAsync(Action<string> progressCallback)
        {
            string databaseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "password_history.db");

            if (!File.Exists(databaseFilePath))
            {
                SQLiteConnection.CreateFile(databaseFilePath);
                progressCallback?.Invoke("Password history database created.");

                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    await connection.OpenAsync();

                    string createTableSql = "CREATE TABLE PasswordHistory (Id INTEGER PRIMARY KEY, Password TEXT, DateAdded DATETIME, Source TEXT)";
                    using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection))
                    {
                        await createTableCommand.ExecuteNonQueryAsync();
                    }

                    progressCallback?.Invoke("Table created.");
                }
            }
        }

        public async Task InsertPasswordEntryAsync(string password, DateTime dateAdded, string source)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                await connection.OpenAsync();

                string insertSql = "INSERT INTO PasswordHistory (Password, DateAdded, Source) VALUES (@password, @dateAdded, @source)";
                using (SQLiteCommand insertRowCommand = new SQLiteCommand(insertSql, connection))
                {
                    insertRowCommand.Parameters.AddWithValue("@password", password);
                    insertRowCommand.Parameters.AddWithValue("@dateAdded", dateAdded);
                    insertRowCommand.Parameters.AddWithValue("@source", source);

                    await insertRowCommand.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<List<PasswordEntry>> GetAllPasswordEntriesAsync()
        {
            List<PasswordEntry> passwordEntries = new List<PasswordEntry>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                await connection.OpenAsync();

                string selectSql = "SELECT * FROM PasswordHistory";
                using (SQLiteCommand selectRowsCommand = new SQLiteCommand(selectSql, connection))
                using (SQLiteDataReader reader = (SQLiteDataReader)await selectRowsCommand.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        PasswordEntry passwordEntry = new PasswordEntry
                        {
                            Id = reader.GetInt32(0),
                            Password = reader.GetString(1),
                            DateAdded = reader.GetDateTime(2),
                            Source = reader.GetString(3)
                        };
                        passwordEntries.Add(passwordEntry);
                    }
                }
            }

            return passwordEntries;
        }

        public async Task UpdatePasswordEntryAsync(PasswordEntry passwordEntry)
        {
            using (SQLiteConnection connection = new SQLiteConnection(this.ConnectionString))
            {
                await connection.OpenAsync();

                string updateSql = "UPDATE PasswordHistory SET Password = @password, DateAdded = @dateAdded, Source = @source WHERE Id = @id";
                using (SQLiteCommand updateRowCommand = new SQLiteCommand(updateSql, connection))
                {
                    updateRowCommand.Parameters.AddWithValue("@id", passwordEntry.Id);
                    updateRowCommand.Parameters.AddWithValue("@password", passwordEntry.Password);
                    updateRowCommand.Parameters.AddWithValue("@dateAdded", passwordEntry.DateAdded);
                    updateRowCommand.Parameters.AddWithValue("@source", passwordEntry.Source);

                    await updateRowCommand.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeletePasswordEntryAsync(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(this.ConnectionString))
            {
                await connection.OpenAsync();

                string deleteSql = "DELETE FROM PasswordHistory WHERE Id = @id";
                using (SQLiteCommand deleteRowCommand = new SQLiteCommand(deleteSql, connection))
                {
                    deleteRowCommand.Parameters.AddWithValue("@id", id);

                    await deleteRowCommand.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<PasswordEntry> GetPasswordEntryAsync(int id)
        {
            PasswordEntry passwordEntry = null;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                await connection.OpenAsync();

                string selectSql = "SELECT * FROM PasswordHistory WHERE Id = @id";
                using (SQLiteCommand selectRowCommand = new SQLiteCommand(selectSql, connection))
                {
                    selectRowCommand.Parameters.AddWithValue("@id", id);

                    using (SQLiteDataReader reader = (SQLiteDataReader)await selectRowCommand.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            passwordEntry = new PasswordEntry
                            {
                                Id = reader.GetInt32(0),
                                Password = reader.GetString(1),
                                DateAdded = reader.GetDateTime(2),
                                Source = reader.GetString(3)
                            };
                        }
                    }
                }
            }

            return passwordEntry;
        }
    }
}

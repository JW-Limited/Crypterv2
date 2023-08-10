using LILO_Packager.v2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Secure
{
    public class DatabaseHandler : IDatabaseHandler
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
    }
}

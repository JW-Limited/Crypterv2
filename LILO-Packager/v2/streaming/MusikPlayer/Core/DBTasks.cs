using Microsoft.Data.Sqlite;
using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.streaming.MusikPlayer.Core
{

    public class DBTasks
    {
        public string ConnectionString => $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "playlist.db")};Version=3;";

        public async Task InitializeDatabaseAsync(Action<string> progressCallback)
        {
            string databaseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "playlist.db");

            if (!File.Exists(databaseFilePath))
            {
                SQLiteConnection.CreateFile(databaseFilePath);
                progressCallback?.Invoke("Database created.");

                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    await connection.OpenAsync();

                    string createTableSql = "CREATE TABLE PlayedSongs (Id INT, Name TEXT, Artist TEXT, Place TEXT)";
                    using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection))
                    {
                        await createTableCommand.ExecuteNonQueryAsync();
                    }

                    progressCallback?.Invoke("Table created.");
                }
            }
        }

        public async Task InsertSongAsync(string titleInsert, string artist, string place, string id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                await connection.OpenAsync();

                string insertSql = "INSERT INTO PlayedSongs (Id, Name, Artist, Place) VALUES (@id, @titleInsert, @artist, @place)";
                using (SQLiteCommand insertRowCommand = new SQLiteCommand(insertSql, connection))
                {
                    insertRowCommand.Parameters.AddWithValue("@id", id);
                    insertRowCommand.Parameters.AddWithValue("@titleInsert", titleInsert);
                    insertRowCommand.Parameters.AddWithValue("@artist", artist);
                    insertRowCommand.Parameters.AddWithValue("@place", place);

                    await insertRowCommand.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task ShowPlaylistAsync(Action<string> displayCallback)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                await connection.OpenAsync();

                string selectSql = "SELECT * FROM PlayedSongs";
                using (SQLiteCommand selectRowsCommand = new SQLiteCommand(selectSql, connection))
                using (SQLiteDataReader reader = (SQLiteDataReader)await selectRowsCommand.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string artist = reader.GetString(2);
                        string place = reader.GetString(3);
                        displayCallback?.Invoke($"{id}: {name}, Artist: {artist}, Place: {place}");
                    }
                }
            }
        }
    }


}

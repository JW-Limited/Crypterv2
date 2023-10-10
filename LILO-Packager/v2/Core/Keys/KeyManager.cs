using LILO_Packager.v2.Core.Keys.Types;
using LILO_Packager.v2.Core.LILO.Types;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Keys
{
    public class Manager
    {
        private static readonly char[] PasswordCharacters =
        {
              'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
              'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
              '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
              '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '`', '~', ',', '.', '?', '/'
        };

        private readonly IPasswordRepository _databaseHandler;
        private readonly UserRole _userRole;

        public Manager(IPasswordRepository databaseHandler, UserRole userRole)
        {
            _databaseHandler = databaseHandler;
            _userRole = userRole;

            _databaseHandler.InitializeDatabaseAsync(callback => { });
        }


        public async Task AddPasswordEntryAsync(string password, DateTime dateAdded, string source)
        {
            if (!_userRole.HasPermission(Permission.WritePasswordEntry))
            {
                throw new UnauthorizedAccessException();
            }

            var _password = new Key(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }).Encrypt(password);
            var __password = BitConverter.ToString(_password);

            await _databaseHandler.InsertPasswordEntryAsync(__password, dateAdded, source);
        }

        public async Task<List<PasswordEntry>> GetAllPasswordEntriesAsync()
        {
            if (!_userRole.HasPermission(Permission.ReadPasswordEntry))
            {
                throw new UnauthorizedAccessException();
            }

            return await _databaseHandler.GetAllPasswordEntriesAsync();
        }

        public async Task<PasswordEntry> GetPasswordEntryAsync(int id)
        {
            if (!_userRole.HasPermission(Permission.ReadPasswordEntry))
            {
                throw new UnauthorizedAccessException();
            }

            List<PasswordEntry> passwordEntries = await GetAllPasswordEntriesAsync();
            return passwordEntries.FirstOrDefault(passwordEntry => passwordEntry.Id == id) ?? new PasswordEntry();
        }

        public async Task DeletePasswordEntryAsync(int id)
        {
            if (!_userRole.HasPermission(Permission.DeletePasswordEntry))
            {
                throw new UnauthorizedAccessException();
            }

            await _databaseHandler.DeletePasswordEntryAsync(id);
        }

        public async Task UpdatePasswordEntryAsync(PasswordEntry entry)
        {
            if (!_userRole.HasPermission(Permission.WritePasswordEntry))
            {
                throw new UnauthorizedAccessException();
            }

            await _databaseHandler.UpdatePasswordEntryAsync(entry);
        }

        public async Task<PasswordEntry> GetPasswordById(int id)
        {
            if (!_userRole.HasPermission(Permission.ReadPasswordEntry))
            {
                throw new UnauthorizedAccessException();
            }

            var entrys = await _databaseHandler.GetAllPasswordEntriesAsync();
            return entrys.FirstOrDefault(e => e.Id == id) ?? new PasswordEntry();
        }



        public static string GeneratePassword(int length, int nomSChar)
        {
            if (length < 12)
            {
                throw new ArgumentException("The password length must be at least 12 characters.");
            }

            if (nomSChar < 1)
            {
                throw new ArgumentException("The number of special characters must be at least 1.");
            }

            StringBuilder passwordBuilder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int characterIndex = random.Next(PasswordCharacters.Length);
                passwordBuilder.Append(PasswordCharacters[characterIndex]);
            }

            for (int i = 0; i < nomSChar; i++)
            {
                int specialCharacterIndex = random.Next(PasswordCharacters.Length);
                while (!IsSpecialCharacter(PasswordCharacters[specialCharacterIndex]))
                {
                    specialCharacterIndex = random.Next(PasswordCharacters.Length);
                }

                passwordBuilder.Insert(random.Next(passwordBuilder.Length), PasswordCharacters[specialCharacterIndex]);
            }

            return passwordBuilder.ToString();
        }

        private static bool IsSpecialCharacter(char character)
        {
            return character == '!' || character == '@' || character == '#' || character == '$' || character == '%' || character == '^' || character == '&' || character == '*' || character == '(' || character == ')' || character == '-' || character == '_';
        }
    }
}

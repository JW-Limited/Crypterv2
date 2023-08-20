using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LILO_Packager.v2.Core.LILO;

public enum ProductType
{
    TorBrowser,
    Uploader,
    Encrypter
}

public class LicenseManager
{
    private readonly Dictionary<string, ProductType> _allProducts = new Dictionary<string, ProductType>
    {
        { "torBrowser", ProductType.TorBrowser },
        { "down/upLoader", ProductType.Uploader },
        { "de/enCrypter", ProductType.Encrypter }
    };

    private bool _licenseFound;

    public async Task<bool> ReadLicensesAsync(string username)
    {
        var licensesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".licenses");
        Directory.CreateDirectory(licensesDirectory);

        try
        {
            var userProductsUrl = "https://pastebin.com/raw/Jy4vF2gd";
            using (var client = new WebClient())
            {
                var userProductsData = await client.DownloadStringTaskAsync(userProductsUrl);
                var userProductsLines = userProductsData.Split('\n');

                foreach (var line in userProductsLines)
                {
                    var components = line.Split('=');
                    if (components.Length == 2)
                    {
                        var user = components[0].Trim();
                        var product = components[1].Trim();

                        if (user == username && _allProducts.ContainsKey(product))
                        {
                            MessageBox.Show($"{product} wurde aktiviert!\n\nViel Spaß!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            File.Delete(Path.Combine(licensesDirectory, "temp_logUI.tmp"));
                            Application.Restart();
                            return true;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        MessageBox.Show("Sie besitzen noch nichts!");
        return false;
    }

    public async Task<bool> SaveIngredientsAsync(string username, string password)
    {
        try
        {
            var ingredients = $"{username}:{password}";
            var encryptedIngredients = Encrypt(ingredients);

            await File.WriteAllTextAsync(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User.dll"), encryptedIngredients);

            MessageBox.Show("Ingredients saved securely!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while saving ingredients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public async Task<bool> SaveUserToUser(params string[] userDetail)
    {
        var user = new User()
        {
            Email = userDetail[0],
            Password = userDetail[1],
            Role = userDetail[2],
            RegistrationDate = DateTime.Now,
        };

        try
        {
            await UserManager.Instance().SaveUserToFile(user);

            return true;
        }
        catch
        { 
            return false;
        }
    }

    private string Encrypt(string data)
    {
        return data; // Replace with actual encryption logic
    }

    public async Task<bool> LogInAsync(string username, string password)
    {
        try
        {
            var userPSWUrl = "https://pastebin.com/raw/9KhiAJTd";
            using (var client = new WebClient())
            {
                var userPSWData = await client.DownloadStringTaskAsync(userPSWUrl);
                var userPSWLines = userPSWData.Split('\n');

                foreach (var line in userPSWLines)
                {
                    var components = line.Split('=');
                    if (components.Length >= 2)
                    {
                        var user = components[0].Trim();
                        var psw = components[1].Trim();

                        if (user == username && psw == password)
                        {
                            _licenseFound = true;

                            await SaveUserToUser(components);

                            //await SaveIngredientsAsync(username, password);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        catch (WebException webEx)
        {
            MessageBox.Show("Network Error");
        }
        finally
        {
            // Perform final actions
            // Your implementation here
        }

        return false;
    }
}
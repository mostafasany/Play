using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System;
using System.IO;
using Windows.ApplicationModel;
using Windows.Storage;

namespace Core
{
    public class DatabaseManager
    {
        const string FileName = "PlayDB.sqlite";
        public static async void CopyDatabase()
        {
            StorageFile file = null;
            try
            {
                file = await ApplicationData.Current.LocalFolder.GetFileAsync(FileName);
            }
            catch (Exception)
            {
            }
            if (file == null)
            {
                string assetsFolder = Path.Combine(Package.Current.InstalledLocation.Path, "Assets");
                string filePathInAssets = Path.Combine(assetsFolder, FileName);
                StorageFile sqliteFile = await StorageFile.GetFileFromPathAsync(filePathInAssets);
                await sqliteFile.CopyAsync(ApplicationData.Current.LocalFolder);
            }

            Core.Services.DatabaseManager.DBConnection = DBConnection;
        }

        public static SQLiteConnection DBConnection
        {
            get
            {
                return new SQLiteConnection(new SQLitePlatformWinRT(),
                    Path.Combine(ApplicationData.Current.LocalFolder.Path, FileName));
            }
        }
    }
}

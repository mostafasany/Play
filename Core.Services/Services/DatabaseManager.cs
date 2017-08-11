using SQLite.Net;

namespace Core.Services
{
    public class DatabaseManager
    {
        public static SQLiteConnection DBConnection { get; set; }
    }
}

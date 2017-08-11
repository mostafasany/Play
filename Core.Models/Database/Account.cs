using SQLite.Net.Attributes;

namespace Core.Models.Database
{
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string FName { get; set; }
    }
}

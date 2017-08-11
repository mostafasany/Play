using SQLite.Net;
using System;
using System.Collections.Generic;


namespace Core.Services.Services.Account
{
    public class AccountService : IAccountService
    {
        public List<Models.Model.Account> GetFacebookFriendsAsync()
        {
            var accountList = new List<Core.Models.Model.Account>();
            TableQuery<Core.Models.Database.Account> allAccounts =
                DatabaseManager.DBConnection.Table<Core.Models.Database.Account>();
            if (allAccounts == null)
                return accountList;
            foreach (var item in allAccounts)
            {
                accountList.Add(new Core.Models.Model.Account { Id = item.Id, FirstName = item.FName });
            }
            return accountList;
        }
    }
}

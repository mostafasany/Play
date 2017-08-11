using System.Collections.Generic;

namespace Core.Services.Services.Account
{
    public interface IAccountService
    {
        List<Models.Model.Account> GetFacebookFriendsAsync();
    }
}

using Core.Models.Model;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;

namespace Core.ViewModels.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            LeaguePlayers = new List<Account>();
            LeaguePlayers.Add(new Account
            {
                Rank = 1,
                UserName = "Mostafa",
                Image = "https://i.ytimg.com/vi/fIkcTXj6oMo/maxresdefault.jpg"
            });
            LeaguePlayers.Add(new Account
            {
                Rank = 2,
                UserName = "Ahmed",
                Image = "https://i.ytimg.com/vi/fIkcTXj6oMo/maxresdefault.jpg"
            });
            LeaguePlayers.Add(new Account
            {
                Rank = 3,
                UserName = "Hassan",
                Image = "https://i.ytimg.com/vi/fIkcTXj6oMo/maxresdefault.jpg"
            });
            LeaguePlayers.Add(new Account
            {
                Rank = 4,
                UserName = "Ali",
                Image = "https://i.ytimg.com/vi/fIkcTXj6oMo/maxresdefault.jpg"
            });
        }

        #region Properties

        List<Account> leaguePlayers;
        public List<Account> LeaguePlayers
        {
            get
            {
                return leaguePlayers;
            }
            set
            {
                leaguePlayers = value;
                RaisePropertyChanged(() => LeaguePlayers);
            }
        }

        #endregion

        #region Commands

        #region Login Command

        RelayCommand onLoginCommand;
        public RelayCommand OnLoginCommand
        {
            get
            {
                if (onLoginCommand == null)
                {
                    onLoginCommand = new RelayCommand(OnLogin);
                }
                return onLoginCommand;
            }
        }

        void OnLogin()
        {

        }

        #endregion

        #endregion

    }
}

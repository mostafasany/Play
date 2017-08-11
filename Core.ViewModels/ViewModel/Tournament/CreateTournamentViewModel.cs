using Core.Models.Model;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Linq;

namespace Core.ViewModels.ViewModel
{
    public class CreateTournamentViewModel : BaseViewModel
    {
        public CreateTournamentViewModel()
        {
            AllAccounts = new List<Account>
            {
                    new Account { UserName="Eliwa" ,Email="ahmedELiwa@gmail.com",FirstName="Ahmed",LastName="Eliwa",Mobile=01213412321,Rank=3,Image="/Assets/PlayersImages/Eliwa.jpg"},
                    new Account { UserName="Mina" ,Email="ahmedELiwa@gmail.com",FirstName="Ahmed",LastName="Eliwa",Mobile=01213412321,Rank=3,Image="/Assets/PlayersImages/Mina.jpg"},
                    new Account { UserName="Maher" ,Email="ahmedELiwa@gmail.com",FirstName="Ahmed",LastName="Eliwa",Mobile=01213412321,Rank=3,Image="/Assets/PlayersImages/Maher.jpg"},
                    new Account { UserName="Ibrahim" ,Email="ahmedELiwa@gmail.com",FirstName="Ahmed",LastName="Eliwa",Mobile=01213412321,Rank=3,Image="/Assets/PlayersImages/Eliwa.jpg"},
                    new Account { UserName="Mostafa" ,Email="ahmedELiwa@gmail.com",FirstName="Ahmed",LastName="Eliwa",Mobile=01213412321,Rank=3,Image="/Assets/PlayersImages/Eliwa.jpg"},
                    new Account { UserName="Tarek" ,Email="ahmedELiwa@gmail.com",FirstName="Ahmed",LastName="Eliwa",Mobile=01213412321,Rank=3,Image="/Assets/PlayersImages/Tarek.jpg"}
            };

            LeaguePlayers = new List<Account>(AllAccounts);

            League = new Tournament
            {
                Name = "Enter League name",
                NoOfPlayers = 5,
                Image = "/Assets/upload.png",
                Players = new List<Account> { }
            };

        }

        #region Properties

        string search;
        public string Search
        {
            set
            {
                search = value;
                if (string.IsNullOrEmpty(search))
                {
                    LeaguePlayers = new List<Account>(AllAccounts);
                }
                else
                {
                    var playerFiltered = AllAccounts
                  .Where(a => !string.IsNullOrEmpty(a.UserName)
                  && a.UserName.ToLower().Contains(search.ToLower()));

                    LeaguePlayers = new List<Account>(playerFiltered);
                }

            }
            get { return search; }
        }

        public Tournament League { get; set; }

        public List<Account> AllAccounts { get; set; }

        private List<Account> leaguePlayers;

        public List<Account> LeaguePlayers
        {
            get { return leaguePlayers; }
            set { leaguePlayers = value; RaisePropertyChanged(() => LeaguePlayers); }
        }

        #endregion

        #region Commands

        #region OnClickUploadCommand

        RelayCommand onClickUpload;

        public RelayCommand OnClickUploadCommand
        {
            get
            {
                if (onClickUpload == null)
                {
                    onClickUpload = new RelayCommand(OpenCamera);
                }
                return onClickUpload;
            }
        }

        async void OpenCamera()
        {

        }

        #endregion

        #region OnPlayerSelectionChangedCommand

        RelayCommand<object> onPlayerSelectionChangedCommand;

        public RelayCommand<object> OnPlayerSelectionChangedCommand
        {
            get
            {
                if (onPlayerSelectionChangedCommand == null)
                {
                    onPlayerSelectionChangedCommand = new RelayCommand<object>(OnPlayerSelectionChanged);
                }
                return onPlayerSelectionChangedCommand;
            }
        }

        async void OnPlayerSelectionChanged(object obj)
        {

        }

        #endregion

        #region OnAddCommand
        RelayCommand onAddCommand;
        public RelayCommand OnAddCommand
        {
            get
            {
                if (onAddCommand == null)
                {
                    onAddCommand = new RelayCommand(OnAdd);
                }
                return onAddCommand;
            }
        }

        async void OnAdd()
        {

        }
        #endregion

        #endregion
    }
}

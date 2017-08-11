using Core.Models.Model;
using Core.Services.Services.Account;
using Core.ViewModels.ViewModel;
using GalaSoft.MvvmLight.Command;

namespace Core.ViewModels.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {

        public LoginViewModel(IAccountService accountService)
        {
            _accountService = accountService;
        }

        #region Private Members

        IAccountService _accountService;

        #endregion

        #region Properties

        public Account User { get; set; }

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

        async void OnLogin()
        {

        }

        #endregion

        #endregion

    }
}

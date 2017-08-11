using Core.Services.Dialog;
using Core.Services.Internet;
using Core.Services.Navigation;
using Core.Services.PlatformServices.Dialog;
using Core.Services.PlatformServices.Internet;
using Core.Services.PlatformServices.Navigation;
using Core.Services.Services.Account;
using Core.Services.Services.Cup;
using Core.Services.Services.League;
using Core.Services.Services.Network;
using Core.ViewModels.ViewModel;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Core
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            RegisterViewModels();
            RegisterServices();
        }

        void RegisterViewModels()
        {
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<SignUpViewModel>();
            SimpleIoc.Default.Register<CreateTournamentViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<MyCupsViewModel>();
            SimpleIoc.Default.Register<MyLeagueViewModel>();
            SimpleIoc.Default.Register<MatchViewModel>();
        }

        void RegisterServices()
        {
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<IInternetService, InternetService>();
            SimpleIoc.Default.Register<IDialogService, DialogService>();
            SimpleIoc.Default.Register<INetworkService, NetworkService>();
            SimpleIoc.Default.Register<IAccountService, AccountService>();
            SimpleIoc.Default.Register<ICupService, CupService>();
            SimpleIoc.Default.Register<ILeagueService, LeagueService>();
        }

        public LoginViewModel LoginViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }

        public SignUpViewModel SignUpViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SignUpViewModel>();
            }
        }

        public CreateTournamentViewModel CreateTournamentViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CreateTournamentViewModel>();
            }
        }

        public HomeViewModel HomeViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HomeViewModel>();
            }
        }

        public MyLeagueViewModel MyLeagueViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MyLeagueViewModel>();
            }
        }

        public MyCupsViewModel MyCupsViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MyCupsViewModel>();
            }
        }

        public MatchViewModel MatchViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MatchViewModel>();
            }
        }

    }
}
using Windows.Networking.Connectivity;
using Core.Services.PlatformServices.Internet;

namespace Core.Services.Internet
{
    public class InternetService : IInternetService
    {
        public bool IsInternet()
        {
            var isConnected = false;
            var profile = NetworkInformation.GetInternetConnectionProfile();
            if (profile != null)
                isConnected = profile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
            return isConnected;
        }
    }
}

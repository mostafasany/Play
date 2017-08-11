using System.Threading.Tasks;

namespace Core.Services.Services.Network
{
    public interface INetworkService
    {
        Task<HttpResult<T>> HttpGetAsync<T>(string url) where T : class;
    }
}

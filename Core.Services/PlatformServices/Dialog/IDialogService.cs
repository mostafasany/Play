using System.Threading.Tasks;

namespace Core.Services.PlatformServices.Dialog
{
    public interface IDialogService
    {
        Task ShowMessage(string message, string header = "");
    }
}

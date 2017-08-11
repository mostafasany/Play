using Core.Services.PlatformServices.Dialog;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Core.Services.Dialog
{
    public class DialogService : IDialogService
    {
        public async Task ShowMessage(string message, string header = "")
        {
            MessageDialog dialog = new MessageDialog(message, header);
            await dialog.ShowAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using Core.Models.Enum;

namespace Core.Services.PlatformServices.Navigation
{
    public interface INavigationService
    {
        Dictionary<string, Type> PagesByKey { get; set; }
        void Navigate(PageType type, object parameter = null);
        void NavigateBack();
        void SetupNavigation();
    }
}

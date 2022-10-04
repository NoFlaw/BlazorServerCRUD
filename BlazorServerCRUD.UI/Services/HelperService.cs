using Microsoft.AspNetCore.Components;

namespace BlazorServerCRUD.UI.Service
{
    public class HelperService
    {
        private NavigationManager _navigationManager;

        public HelperService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public void NavigateTo(string path, bool forceReload)
        {
            _navigationManager.NavigateTo(path, forceReload);
        }
    }    
}

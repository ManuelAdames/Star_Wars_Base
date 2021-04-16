using Prism.Navigation;
using Prism.Services;
using Star_Wars_Base.Models;
using Star_Wars_Base.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;


namespace Star_Wars_Base.ViewModels
{
    public class StarshipsViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.StarshipsTitle;
        public ObservableCollection<StarShips> StarshipsCollection { get; set; }

        private IStarShipsService _starshipsService;
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;

        public StarshipsViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IStarShipsService starshipsService) : base(navigationService, pageDialogService)
        {
            _starshipsService = starshipsService;
            GetApp();
        }

        public async Task GetStarshipsList()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.", "Ok");
            }
            else
            {
                var getstarships = await _starshipsService.GetStarShipAsync();
                StarshipsCollection = getstarships.ResultStarships;
            }
            IsBusy = false;
        }
        public async void GetApp()
        {
            await GetStarshipsList();

        }
    }
}
    


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
    public class PlanetsViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.PlanetsTitle;
        public ObservableCollection<Planets> PlanetsCollection { get; set; }

        private IPlanetsService _planetsService;
        public bool IIIsBusy { get; set; }
        public bool IsNotBusy => !IIIsBusy;

        public PlanetsViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IPlanetsService planetsService) : base(navigationService, pageDialogService)
        {
            _planetsService = planetsService;
            GetApp();
        }

        public async Task GetPlanetsList()
        {
            IIIsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.", "Ok");
            }
            else
            {
                var getplanets = await _planetsService.GetPlanetAsync();
                PlanetsCollection = getplanets.ResultsPlanets;
            }
            IIIsBusy = false;
        }
        public async void GetApp()
        {
            await GetPlanetsList();

        }
    }
}
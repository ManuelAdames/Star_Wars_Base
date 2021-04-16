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
    class VehiclesViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.VehiclesTitle;
        public ObservableCollection<Vehicles> VehiclesCollection { get; set; }

        private IVehiclesService _vehiclesService;
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;

        public VehiclesViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IVehiclesService vehiclesService) : base(navigationService, pageDialogService)
        {
            _vehiclesService = vehiclesService;
            GetApp();
        }

        public async Task GetVehiclesList()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.", "Ok");
            }
            else
            {
                var getvehicles = await _vehiclesService.GetVehicleAsync();
                VehiclesCollection = getvehicles.ResultsVehicles;
            }
            IsBusy = false;
        }
        public async void GetApp()
        {
            await GetVehiclesList();

        }
    }
}
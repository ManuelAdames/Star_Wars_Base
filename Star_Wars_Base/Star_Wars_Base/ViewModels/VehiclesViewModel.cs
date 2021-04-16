using Prism.Navigation;
using Prism.Services;
using Star_Wars_Base.Models;
using Star_Wars_Base.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Base.ViewModels
{
    public class VehiclesViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.VehiclesTitle;
        public ObservableCollection<Vehicles> VehiclesCollection { get; set; } = new ObservableCollection<Vehicles>();

        public VehiclesViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IFilmsService filmsService, IPeopleService peopleService, IPlanetsService planetsService, ISpeciesService speciesService, IStarShipsService starShipsService, IVehiclesService vehiclesService) : base(navigationService, pageDialogService, filmsService, peopleService, planetsService, speciesService, starShipsService, vehiclesService)
        {
            GetApp();
        }
        public async Task GetVehicleList()
        {
            var getvehicles = await VehiclesService.GetVehicleAsync();
            VehiclesCollection = new ObservableCollection<Vehicles>(getvehicles.ResultsVehicles);
        }

        public async void GetApp()
        {
            await GetVehicleList();

        }
    }
}

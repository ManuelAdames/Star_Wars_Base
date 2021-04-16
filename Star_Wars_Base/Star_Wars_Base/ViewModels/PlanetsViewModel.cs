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
    public class PlanetsViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.PlanetsTitle;
        public ObservableCollection<Planets> PlanetCollection { get; set; } = new ObservableCollection<Planets>();

        public PlanetsViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IFilmsService filmsService, IPeopleService peopleService, IPlanetsService planetsService, ISpeciesService speciesService, IStarShipsService starShipsService, IVehiclesService vehiclesService) : base(navigationService, pageDialogService, filmsService, peopleService, planetsService, speciesService, starShipsService, vehiclesService)
        {
            GetApp();
        }
        public async Task GetPlanetList()
        {
            var getplanet = await PlanetsService.GetPlanetAsync();
            PlanetCollection = new ObservableCollection<Planets>(getplanet.ResultsPlanets);
        }

        public async void GetApp()
        {
            await GetPlanetList();

        }
    }
}

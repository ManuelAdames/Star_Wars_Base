using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Prism.Navigation;
using Prism.Services;
using Star_Wars_Base.Services;

namespace Star_Wars_Base.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public abstract string Title { get; set; }
        protected INavigationService NavigationService { get; }
        protected IFilmsService FilmsService { get; }
        protected IPeopleService PeopleService { get; }
        protected IPlanetsService PlanetsService { get; }
        protected ISpeciesService SpeciesService { get; }
        protected IStarShipsService StarShipsService { get; }
        protected IVehiclesService VehiclesService { get; }
        protected IPageDialogService AlertService { get; }

        protected BaseViewModel(INavigationService navigationService,IPageDialogService pageDialogService,IFilmsService filmsService, IPeopleService peopleService, IPlanetsService planetsService, ISpeciesService speciesService, IStarShipsService starShipsService, IVehiclesService vehiclesService)
        {
            NavigationService = navigationService;
            AlertService = pageDialogService;
            FilmsService = filmsService;
            PeopleService = peopleService;
            PlanetsService = planetsService;
            SpeciesService = speciesService;
            StarShipsService = starShipsService;
            VehiclesService = vehiclesService;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Star_Wars_Base.Models;
using System.Windows.Input;
using Prism.Services;
using Prism.Navigation;
using Star_Wars_Base.Views;
using Star_Wars_Base.Constants;

namespace Star_Wars_Base.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.HomeTitle;
        public MenuOption Films { get; set; } = new MenuOption();
        public MenuOption People { get; set; } = new MenuOption();
        public MenuOption Planets { get; set; } = new MenuOption();
        public MenuOption Species { get; set; } = new MenuOption();
        public MenuOption Starships { get; set; } = new MenuOption();
        public MenuOption Vehicles { get; set; } = new MenuOption();
        public ICommand FilmsCommand { get; }
        public ICommand PeopleCommand { get; }
        public ICommand PlanetsCommand { get; }
        public ICommand SpeciesCommand { get; }
        public ICommand StarshipsCommand { get; }
        public ICommand VehiclesCommand { get; }


        public HomeViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            Films.Title = "Films"; Films.Image = "films.png";
            People.Title = "People"; People.Image = "people.png";
            Planets.Title = "Planets"; Planets.Image = "planets.png";
            Species.Title = "Species"; Species.Image = "species.png";
            Starships.Title = "Starships"; Starships.Image = "starships.png";
            Vehicles.Title = "Vehicles"; Vehicles.Image = "vehicles.png";

            FilmsCommand = new Command(OnFilms);
            PeopleCommand = new Command(OnPeople);
            PlanetsCommand = new Command(OnPlanets);
            SpeciesCommand = new Command(OnSpecies);
            StarshipsCommand = new Command(OnStarships);
            VehiclesCommand = new Command(OnVehicles);

        }

        private async void OnVehicles(object obj)
        {
            await NavigationService.NavigateAsync("/Navigate/Vehicles");
        }

        private async void OnStarships(object obj)
        {
            await NavigationService.NavigateAsync("/Navigate/Starships");
        }

        private async void OnSpecies(object obj)
        {
            await NavigationService.NavigateAsync("/Navigate/Species");
        }

        private async void OnPlanets(object obj)
        {
            await NavigationService.NavigateAsync("Planets");
        }

        private async void OnPeople(object obj)
        {
            await NavigationService.NavigateAsync("People");
        }

        private async void OnFilms(object obj)
        {
            await NavigationService.NavigateAsync("/Navigate/Films");
        }
    }
}

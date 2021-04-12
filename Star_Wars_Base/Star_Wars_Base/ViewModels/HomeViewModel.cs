using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Star_Wars_Base.Models;
using System.Windows.Input;

namespace Star_Wars_Base.ViewModels
{
    public class HomeViewModel
    {
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


        public HomeViewModel()
        {
            Films.Title = "Films"; //Films.Image = ".png";
            People.Title = "People"; //People.Image = ".png";
            Planets.Title = "Planets"; //Planets.Image = ".png";
            Species.Title = "Species"; //Species.Image = ".png";
            Starships.Title = "Starships"; //Starships.Image = ".png";
            Vehicles.Title = "Vehicles"; //Vehicles.Image = ".png";

            FilmsCommand = new Command(OnFilms);
            PeopleCommand = new Command(OnPeople);
            PlanetsCommand = new Command(OnPlanets);
            SpeciesCommand = new Command(OnSpecies);
            StarshipsCommand = new Command(OnStarships);
            VehiclesCommand = new Command(OnVehicles);

        }

        private void OnVehicles(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnStarships(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnSpecies(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnPlanets(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnPeople(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnFilms(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

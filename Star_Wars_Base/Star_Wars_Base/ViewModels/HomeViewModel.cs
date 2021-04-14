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
using Prism.Commands;
using Star_Wars_Base.Services;

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
        public MenuOption HomeOption { get; set; } = new MenuOption();
        public MenuOption AboutUs { get; set; } = new MenuOption();
        public MenuOption Contact { get; set; } = new MenuOption();

        public HomeViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IFilmsService filmsService) : base(navigationService, pageDialogService,filmsService)
        {
            Films.Title = "Films"; Films.Image = "yoda.png";
            People.Title = "People"; People.Image = "stormtrooper.png";
            Planets.Title = "Planets"; Planets.Image = "planets.png";
            Species.Title = "Species"; Species.Image = "robot.png";
            Starships.Title = "Starships"; Starships.Image = "ship.png";
            Vehicles.Title = "Vehicles"; Vehicles.Image = "vehicles.png";
            HomeOption.Title = "Home";
            AboutUs.Title = "About Us";
            Contact.Title = "Contact";
        }
        public DelegateCommand HomeCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("Home"));
        public DelegateCommand FilmsCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("NavigationPage/Films"));
        public DelegateCommand PeopleCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("NavigationPage/People"));
        public DelegateCommand PlanetsCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("NavigationPage/Planets"));
        public DelegateCommand SpeciesCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("NavigationPage/Species"));
        public DelegateCommand StarshipsCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("NavigationPage/Starships"));
        public DelegateCommand VehiclesCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("NavigationPage/Vehicles"));
        public DelegateCommand ContactCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("NavigationPage/Contact"));
        public DelegateCommand AboutUsCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("NavigationPage/AboutUs"));

    }
}

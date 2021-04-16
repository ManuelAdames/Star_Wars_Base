using Prism;
using Prism.Ioc;
using Prism.Unity;
using Prism.Navigation;
using Prism.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Star_Wars_Base.ViewModels;
using Star_Wars_Base.Views;
using Star_Wars_Base.Constants;
using Star_Wars_Base.Services;

namespace Star_Wars_Base
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null): base(initializer) { }
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(NavigationConstants.StartPage);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>(NavigationConstants.Home);
            containerRegistry.RegisterForNavigation<FilmsPage, FilmsViewModel>(NavigationConstants.Films);
            containerRegistry.RegisterForNavigation<PeoplePage, PeopleViewModel>(NavigationConstants.People);
            containerRegistry.RegisterForNavigation<PlanetsPage, PlanetsViewModel>(NavigationConstants.Planets);
            containerRegistry.RegisterForNavigation<SpeciesPage, SpeciesViewModel>(NavigationConstants.Species);
            containerRegistry.RegisterForNavigation<StarshipsPage, StarshipsViewModel>(NavigationConstants.Starships);
            containerRegistry.RegisterForNavigation<VehiclesPage, VehiclesViewModel>(NavigationConstants.Vehicles);
           
            containerRegistry.RegisterForNavigation<ContactPage, HomeViewModel>(NavigationConstants.Contact);
            containerRegistry.RegisterForNavigation<AboutUsPage, HomeViewModel>(NavigationConstants.AboutUs);
            containerRegistry.RegisterForNavigation<StartPage, HomeViewModel>(NavigationConstants.StartPage);
            
            containerRegistry.RegisterForNavigation<FilmDetailPage, FilmsViewModel>(NavigationConstants.FilmDetailPage);
            
            containerRegistry.Register<IFilmsService,FilmsService>();
            containerRegistry.Register<IPeopleService,PeopleService>();
            containerRegistry.Register<IPlanetsService, PlanetsService>();
            containerRegistry.Register<ISpeciesService, SpeciesService>();
            containerRegistry.Register<IStarShipsService, StarShipsService>();
            containerRegistry.Register<IVehiclesService, VehiclesService>();
            
            containerRegistry.RegisterForNavigation<NavigationPage>();

        }
    }
}

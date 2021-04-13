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

namespace Star_Wars_Base
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null): base(initializer) { }
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("Home");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>(NavigationConstants.Home);
            containerRegistry.RegisterForNavigation<FilmsPage, FilmsViewModel>(NavigationConstants.Films);
            containerRegistry.RegisterForNavigation<PeoplePage, HomeViewModel>(NavigationConstants.People);
            containerRegistry.RegisterForNavigation<PlanetsPage, HomeViewModel>(NavigationConstants.Planets);
            containerRegistry.RegisterForNavigation<SpeciesPage, HomeViewModel>(NavigationConstants.Species);
            containerRegistry.RegisterForNavigation<StarshipsPage, HomeViewModel>(NavigationConstants.Starships);
            containerRegistry.RegisterForNavigation<VehiclesPage, HomeViewModel>(NavigationConstants.Vehicles);

            containerRegistry.RegisterForNavigation<NavigationPage>();

        }
    }
}

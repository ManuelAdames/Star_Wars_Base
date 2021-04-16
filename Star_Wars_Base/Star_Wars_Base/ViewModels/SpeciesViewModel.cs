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
    public class SpeciesViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.SpeciesTitle;
        public ObservableCollection<Species> SpecieCollection { get; set; } = new ObservableCollection<Species>();

        public SpeciesViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IFilmsService filmsService, IPeopleService peopleService, IPlanetsService planetsService, ISpeciesService speciesService, IStarShipsService starShipsService, IVehiclesService vehiclesService) : base(navigationService, pageDialogService, filmsService, peopleService, planetsService, speciesService, starShipsService, vehiclesService)
        {
            GetApp();
        }
        public async Task GetSpeciesList()
        {
            var getspecies = await SpeciesService.GetSpecieAsync();
            SpecieCollection = new ObservableCollection<Species>(getspecies.ResultSpecies);
        }

        public async void GetApp()
        {
            await GetSpeciesList();

        }
    }
}

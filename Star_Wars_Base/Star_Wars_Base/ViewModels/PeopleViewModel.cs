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
    public class PeopleViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.PeopleTitle;
        public ObservableCollection<People> PeopleCollection { get; set; } = new ObservableCollection<People>();

        public PeopleViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IFilmsService filmsService, IPeopleService peopleService, IPlanetsService planetsService, ISpeciesService speciesService, IStarShipsService starShipsService, IVehiclesService vehiclesService) : base(navigationService, pageDialogService, filmsService, peopleService, planetsService, speciesService, starShipsService, vehiclesService)        
        {
            GetApp();
        }
        public async Task GetPeopleList()
        {
            var getpeople = await PeopleService.GetPeopleAsync();
            PeopleCollection = new ObservableCollection<People>(getpeople.ResultsPeople);
        }

        public async void GetApp()
        {
            await GetPeopleList();

        }
    }
}

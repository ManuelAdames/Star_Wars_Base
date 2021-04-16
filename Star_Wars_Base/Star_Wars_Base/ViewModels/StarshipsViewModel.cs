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
    public class StarshipsViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.StarshipsTitle;
        public ObservableCollection<StarShips> StarshipsCollection { get; set; } = new ObservableCollection<StarShips>();

        public StarshipsViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IFilmsService filmsService, IPeopleService peopleService, IPlanetsService planetsService, ISpeciesService speciesService, IStarShipsService starShipsService, IVehiclesService vehiclesService) : base(navigationService, pageDialogService, filmsService, peopleService, planetsService, speciesService, starShipsService, vehiclesService)
        {
            GetApp();
        }
        public async Task GetStarshipList()
        {
            var getstarships = await StarShipsService.GetStarShipAsync();
            StarshipsCollection = new ObservableCollection<StarShips>(getstarships.ResultStarships);
        }

        public async void GetApp()
        {
            await GetStarshipList();

        }
    }
}

using Prism.Navigation;
using Prism.Services;
using Star_Wars_Base.Models;
using Star_Wars_Base.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Star_Wars_Base.ViewModels
{
    public class SpeciesViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.SpeciesTitle;
        public ObservableCollection<Species> SpeciesCollection { get; set; }

        private ISpeciesService _speciesService;
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;

        public SpeciesViewModel(INavigationService navigationService, IPageDialogService pageDialogService, ISpeciesService speciesService) : base(navigationService, pageDialogService)
        {
            _speciesService = speciesService;
            GetApp();
        }

        public async Task GetSpeciesList()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.", "Ok");
            }
            else
            {
                var getspecies = await _speciesService.GetSpecieAsync();
                SpeciesCollection = getspecies.ResultSpecies;
            }
            IsBusy = false;
        }
        public async void GetApp()
        {
            await GetSpeciesList();

        }
    }
}
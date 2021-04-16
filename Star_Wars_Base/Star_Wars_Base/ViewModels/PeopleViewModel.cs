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
    public class PeopleViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.PeopleTitle;
        public ObservableCollection<People> PeopleCollection { get; set; }

        private IPeopleService _peopleService;
        public bool IIsBusy { get; set; }
        public bool IIsNotBusy => !IIsBusy;

        public PeopleViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IPeopleService peopleService) : base(navigationService, pageDialogService)
        {
            _peopleService = peopleService;
            GetApp();
        }

        public async Task GetPeopleList()
        {
            IIsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.", "Ok");
            }
            else
            {
                var getpeople = await _peopleService.GetPeopleAsync();
                PeopleCollection = getpeople.ResultsPeople;
            }
            IIsBusy = false;
        }
        public async void GetApp()
        {
            await GetPeopleList();

        }
    }
}
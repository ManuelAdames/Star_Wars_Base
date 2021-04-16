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
using Xamarin.Forms;

namespace Star_Wars_Base.ViewModels
{
    public class FilmsViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.FilmsTitle;
        public ObservableCollection<Films> FilmsCollection { get; set; }

        private IFilmsService _filmService;
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;

        public FilmsViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IFilmsService filmsService) : base(navigationService, pageDialogService)
        {
            _filmService = filmsService;
            GetApp();
        }

        public async Task GetFilmList()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.", "Ok");
            }
            else
            {
                var getfilms = await _filmService.GetFilmAsync();
                FilmsCollection = getfilms.ResultsFilms;
            }
            IsBusy = false;
        }
        public async void GetApp()
        {
            await GetFilmList();

        }
    }
}

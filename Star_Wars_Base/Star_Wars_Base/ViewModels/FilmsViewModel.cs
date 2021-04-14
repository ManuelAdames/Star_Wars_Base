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
    public class FilmsViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.FilmsTitle;
        public ObservableCollection<Films> FilmsCollection { get; set; } = new ObservableCollection<Films>();

        public FilmsViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IFilmsService filmsService) : base(navigationService, pageDialogService,filmsService)
        {
            
            GetApp();
            
        }

        public async Task GetFilmList()
        {
            var getfilms = await FilmsService.GetFilmAsync();
            FilmsCollection = new ObservableCollection<Films>(getfilms.ResultsFilms);
        } 

        public async void GetApp()
        {
            await GetFilmList();

        }
    }
}

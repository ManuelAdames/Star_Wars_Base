using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Prism.Navigation;
using Prism.Services;
using Star_Wars_Base.Services;

namespace Star_Wars_Base.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public abstract string Title { get; set; }
        protected INavigationService NavigationService { get; }
        protected IFilmsService FilmsService { get; }
        protected IPageDialogService AlertService { get; }

        protected BaseViewModel(INavigationService navigationService,IPageDialogService pageDialogService,IFilmsService filmsService)
        {
            NavigationService = navigationService;
            AlertService = pageDialogService;
            FilmsService = filmsService;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

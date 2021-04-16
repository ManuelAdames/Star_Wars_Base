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
        protected IPageDialogService AlertService { get; }

        protected BaseViewModel(INavigationService navigationService,IPageDialogService pageDialogService)
        {
            NavigationService = navigationService;
            AlertService = pageDialogService;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

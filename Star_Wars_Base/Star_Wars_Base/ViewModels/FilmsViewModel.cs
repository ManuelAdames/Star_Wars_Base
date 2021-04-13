using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Star_Wars_Base.ViewModels
{
    public class FilmsViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.FilmsTitle;

        public FilmsViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {

        }
    }
}

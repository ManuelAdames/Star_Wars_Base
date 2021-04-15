using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star_Wars_Base.Models;
using Star_Wars_Base.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Star_Wars_Base.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmsPage : ContentPage
    {
        public FilmsPage()
        {
            InitializeComponent();
        }

        async private void FilmsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mySelecterdItem = e.Item as Films;
            switch(mySelecterdItem.EpisodeId)
            {
                case 1:
                    await Navigation.PushAsync(new FilmDetailPage());
                    break;
                case 2:
                    await Navigation.PushAsync(new FilmDetailPage());
                    break;
                case 3:
                    await Navigation.PushAsync(new FilmDetailPage());
                    break;
                case 4:
                    await Navigation.PushAsync(new FilmDetailPage());
                    break;
                case 5:
                    await Navigation.PushAsync(new FilmDetailPage());
                    break;
                case 6:
                    await Navigation.PushAsync(new FilmDetailPage());
                    break;
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}
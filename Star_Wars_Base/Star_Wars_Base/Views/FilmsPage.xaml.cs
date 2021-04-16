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
            var mySelectedItem = e.Item as Films;
            await Navigation.PushAsync(new FilmDetailPage(mySelectedItem.FilmTitle, mySelectedItem.ReleaseDate, mySelectedItem.Director, mySelectedItem.OpeningCrawl));
        }
    }
}
using Star_Wars_Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Star_Wars_Base.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarshipsPage : ContentPage
    {
        public StarshipsPage()
        {
            InitializeComponent();
        }

        private async void StarshipsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mySelectedItem = e.Item as StarShips;
            await Navigation.PushAsync(new StarshipsDetailPage(mySelectedItem.StarshipsName, mySelectedItem.CostInCredits, mySelectedItem.Passengers, mySelectedItem.MaxAtmospheringSpeed, mySelectedItem.Crew));

        }
    }
}
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
    public partial class PlanetsPage : ContentPage
    {
        public PlanetsPage()
        {
            InitializeComponent();
        }

        private async void PlanetsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mySelectedItem = e.Item as Planets;
            await Navigation.PushAsync(new PlanetsDetailPage(mySelectedItem.PlanetsName, mySelectedItem.Climate, mySelectedItem.Gravity, mySelectedItem.Terrain, mySelectedItem.Population));
        }
    }
}
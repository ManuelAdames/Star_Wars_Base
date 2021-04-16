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
    public partial class VehiclesPage : ContentPage
    {
        public VehiclesPage()
        {
            InitializeComponent();
        }

        private async void VehiclesList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mySelectedItem = e.Item as Vehicles;
            await Navigation.PushAsync(new VehicleDetailPage(mySelectedItem.VehiclesName, mySelectedItem.Model, mySelectedItem.CostInCredits, mySelectedItem.Passengers, mySelectedItem.MaxAtmospheringSpeed, mySelectedItem.Crew));
        }
    }
}
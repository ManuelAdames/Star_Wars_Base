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
    public partial class SpeciesPage : ContentPage
    {
        public SpeciesPage()
        {
            InitializeComponent();
        }

        private async void SpeciesList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mySelectedItem = e.Item as Species;
            await Navigation.PushAsync(new SpeciesDetailPage(mySelectedItem.SpeciesName, mySelectedItem.Classification, mySelectedItem.Language, mySelectedItem.AverageLifespan, mySelectedItem.Designation));
        }
    }
}
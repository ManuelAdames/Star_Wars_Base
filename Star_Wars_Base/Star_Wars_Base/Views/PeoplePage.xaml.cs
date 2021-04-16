using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star_Wars_Base.Models;
using Star_Wars_Base.ViewModels;
using Star_Wars_Base.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Star_Wars_Base.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeoplePage : ContentPage
    {
        public PeoplePage()
        {
            InitializeComponent();
        }

        private async void PeopleList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mySelectedItem = e.Item as People;
            await Navigation.PushAsync(new PeopleDetailPage(mySelectedItem.PeopleName, mySelectedItem.Gender, mySelectedItem.BirthYear));
        }
    }
}

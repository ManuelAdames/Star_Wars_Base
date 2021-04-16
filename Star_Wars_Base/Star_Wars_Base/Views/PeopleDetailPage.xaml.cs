using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Star_Wars_Base.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleDetailPage : ContentPage
    {
        public PeopleDetailPage(string name, string gender, string birthYear)
        {
            InitializeComponent();
            LabelName.Text = name;
            LabelGender.Text = gender;
            LabelBirthYear.Text = birthYear;

        }
    }
}
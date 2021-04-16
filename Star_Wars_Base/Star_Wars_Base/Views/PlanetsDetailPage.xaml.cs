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
    public partial class PlanetsDetailPage : ContentPage
    {
        public PlanetsDetailPage(string name, string climate, string gravity, string terrain, string populaiton)
        {
            InitializeComponent();
            LabelName.Text = name;
            LabelClimate.Text = climate;
            LabelGravity.Text = gravity;
            LabelTerrain.Text = terrain;
            LabelPopulation.Text = populaiton;
        }
    }
}
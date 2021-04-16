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
    public partial class SpeciesDetailPage : ContentPage
    {
        public SpeciesDetailPage(string name, string classification, string language, string lifespan, string designation)
        {
            InitializeComponent();
            LabelName.Text = name;
            LabelClassification.Text = classification;
            LabelLanguage.Text = language;
            LabelLifespan.Text = lifespan;
            LabelDesignation.Text = designation; 
        }
    }
}
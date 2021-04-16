using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star_Wars_Base.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Star_Wars_Base.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmDetailPage : ContentPage
    {
        public FilmDetailPage(string name, string date, string director, string crawl)
        {
            InitializeComponent();
            LabelFilmTitle.Text = name;
            LabelDate.Text = date;
            LabelDirector.Text = director ;
            LabelOpeningCrawl.Text = crawl;
        }
    }
}
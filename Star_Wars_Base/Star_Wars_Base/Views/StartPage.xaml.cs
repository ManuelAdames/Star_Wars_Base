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
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            RotateImage();
        }

        
        async Task RotateImage()
        {
            while (true)
            {
                for (int i = 1; i < 7; i++)
                {
                    if (YodaImage.Rotation >= 360f) YodaImage.Rotation = 0;
                    await YodaImage.RotateTo(i * (360 / 6), 1000, Easing.Linear);
                }
            }
        }
        //private void Animate()
        //{
        //    YodaImage.RotateTo(360, 800, Easing.Linear);
        //    YodaImage.RotateTo(0, 0);
        //}
    }
}
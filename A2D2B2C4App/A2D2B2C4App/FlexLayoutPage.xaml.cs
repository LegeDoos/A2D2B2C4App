using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A2D2B2C4App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlexLayoutPage : ContentPage
    {
        public FlexLayoutPage()
        {
            InitializeComponent();

            Seated.Source = ImageSource.FromResource("A2D2B2C4App.Images.SeatedMonkey.jpg");
            Banana.Source = ImageSource.FromResource("A2D2B2C4App.Images.Banana.jpg");
            Facepalm.Source = ImageSource.FromResource("A2D2B2C4App.Images.FacePalm.jpg");
        }
    }
}
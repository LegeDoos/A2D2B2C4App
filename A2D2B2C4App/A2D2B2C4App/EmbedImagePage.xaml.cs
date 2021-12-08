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
    public partial class EmbedImagePage : ContentPage
    {
        public EmbedImagePage()
        {
            InitializeComponent();
            Image.Source = ImageSource.FromResource("A2D2B2C4App.Images.Banana.jpg");
        }

        private void Image1_Tapped(object sender, EventArgs e)
        {
            Image image = (Image)sender;
            if (image.Opacity == 0.15)
            {
                image.Opacity = 1;
            }
            else
            {
                image.Opacity = 0.15;
            }
            
        }
    }
}
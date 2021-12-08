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
    public partial class DownloadImagePage : ContentPage
    {
        public DownloadImagePage()
        {
            InitializeComponent();

            /* var imageSource = (UriImageSource)ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/SA_Barfence.jpg/250px-SA_Barfence.jpg"));
            var imageSource = new UriImageSource { Uri = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/SA_Barfence.jpg/250px-SA_Barfence.jpg") };
            imageSource.CachingEnabled = false;
            imageSource.CacheValidity = TimeSpan.FromHours(1);
            Image.Source = imageSource;
            Image.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/SA_Barfence.jpg/250px-SA_Barfence.jpg";*/



        }
    }
}
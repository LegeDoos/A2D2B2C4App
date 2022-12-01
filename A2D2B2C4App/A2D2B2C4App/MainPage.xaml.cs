using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace A2D2B2C4App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button11_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }

        private async void Button12_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }

        private async void Button13_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        private async void Button14_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());
        }

        private async void Button21_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlexLayoutPage());
        }

        private async void Button22_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DownloadImagePage());
        }

        private async void Button23_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmbedImagePage());
        }

        private async void Button24_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActivityIndicatorPage());
        }

        private async void Button31_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarkupExtensionPage());
        }

        private async void Button32_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedExPage());
        }

        private async void Button33_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarouselExPage());
        }

        private async void Button34_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalExPage());
        }

        private async void Button41_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScrollViewChildPage());
        }

        private async void Button42_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScrollViewPage());
        }

        private async void Button43_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScrollViewHorPage());
        }

        private async void Button44_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SimpleAbsolutePage());
        }

        private async void Button51_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SimpleRelativePage());
        }

        private async void Button52_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SimpleFlexPage());
        }

        private async void Button53_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionPage());
        }

        private async void Button54_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new APICallsPage());
        }
    }
}

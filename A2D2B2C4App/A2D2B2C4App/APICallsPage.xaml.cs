using A2D2B2C4App.Logic;
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
    public partial class APICallsPage : ContentPage
    {
        public APICallsPage()
        {
            InitializeComponent();
        }

        private async void ZoekCocktailNameButton_Clicked(object sender, EventArgs e)
        {
            var cocktails = await CocktailLogic.GetCocktailsByName(CocktailNameEntry.Text);
            CocktailListView.ItemsSource = cocktails;
        }
    }
}
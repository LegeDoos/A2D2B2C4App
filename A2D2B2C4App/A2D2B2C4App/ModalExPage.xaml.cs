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
    public partial class ModalExPage : ContentPage
    {
        public ModalExPage()
        {
            InitializeComponent();
        }

        private async void ModalRemoveButton_Clicked(object sender, EventArgs e)
        {
            if (AgreeCheckbox.IsChecked)
            {
                _ = await Navigation.PopModalAsync();
            }
            else
            {
                WarningLabel.Text = "De checkbox moet aangeklikt zijn om te kunnen verdergaan.";
                SheldonImage.Source = ImageSource.FromResource("A2D2B2C4App.Images.takethel.jpg");
            }
        }

        // probeer hier maar eens uit te geraken met je android button. Fail!
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
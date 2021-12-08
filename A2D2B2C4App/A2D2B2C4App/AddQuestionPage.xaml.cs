using A2D2B2C4App.Model;
using SQLite;
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
    public partial class AddQuestionPage : ContentPage
    {
        public AddQuestionPage()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            int insertedRows;
            Question question = new Question();
            question.QuestionBody = QuestionEntry.Text;

            using (SQLiteConnection sQLiteconnection = new SQLiteConnection(App.DatabaseLocation))
            {
                sQLiteconnection.CreateTable<Question>();
                insertedRows = sQLiteconnection.Insert(question);
            }

            if(insertedRows > 0)
            {
                _ = DisplayAlert("Gelukt!", "Je vraag is goed toegevoegd aan de database.", "Ok");
            }
            else
            {
                _ = DisplayAlert("Ah, jammer! Er ging iets fout.", "Je vraag is NIET toegevoegd aan de database.", "Ok");
            }

            await Navigation.PopAsync();

        }
    }
}
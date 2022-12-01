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
    public partial class QuestionPage : ContentPage
    {
        public QuestionPage()
        {
            InitializeComponent();
        }

        private async void AddToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddQuestionPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection sQLiteConnection = new SQLiteConnection(App.databaseLocation))
            {
                _ = sQLiteConnection.CreateTable<Question>();
                List<Question> questions = sQLiteConnection.Table<Question>().ToList();
                QuestionListView.ItemsSource = questions;
            }
        }

        private void QuestionListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Question selectedQuestion = QuestionListView.SelectedItem as Question;
            if(selectedQuestion != null)
            {
                _ = Navigation.PushAsync(new QuestionDetailPage(selectedQuestion));
            }
        }
    }
}
using Quiz.Services;
using Xamarin.Forms;

namespace Quiz.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnStart_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new QuestionPage(QuestionsStore.Questions, 1), true);
        }
    }
}

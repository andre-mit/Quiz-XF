using Quiz.Models;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage : ContentPage
    {
        private readonly int _questionNumber;
        private readonly List<Question> _questions;
        private readonly int totalPoints;
        private Question Question;
        private bool correctQuestion = false;
        public QuestionPage(List<Question> questions, int questionNumber, int totalPoints = 0)
        {
            InitializeComponent();
            _questionNumber = questionNumber;
            _questions = questions;
            this.totalPoints = totalPoints;

            BindingContext = Question = questions[questionNumber - 1];

            Title = "Pergunta " + questionNumber;

            if (questionNumber < 5)
            {
                btnOk.Text = "Próxima";
            }
            else
            {
                btnOk.Text = "Finalizar";
            }
        }

        private void listQuestions_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItemIndex == Question.Correct)
            {
                correctQuestion = true;
            }
            else
            {
                correctQuestion = false;
            }
            btnOk.IsEnabled = true;
        }

        private async void btnOk_Clicked(object sender, System.EventArgs e)
        {
            int totalPointsFilter = correctQuestion ? totalPoints + 1 : totalPoints;
            if (_questionNumber < 5)
                await Navigation.PushAsync(new QuestionPage(_questions, _questionNumber + 1, totalPointsFilter), true);
            else
            {
                await Navigation.PushAsync(new ResultsPage(totalPointsFilter), true);

            }
        }
    }
}

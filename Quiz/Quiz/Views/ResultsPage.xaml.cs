using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultsPage : ContentPage
    {

        public ResultsPage(int totalPoints)
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

            lblScore.Text = $"Você fez {totalPoints} pontos";

            switch (totalPoints)
            {
                case 0:
                    lblMessage.Text = "Que fracasso em...";
                    break;
                case 1:
                    lblMessage.Text = "Ruim";
                    break;
                case 2:
                    lblMessage.Text = "Ta bom mas ta ruim";
                    break;
                case 3:
                    lblMessage.Text = "Bom, mas da pra melhorar";
                    break;
                case 4:
                    lblMessage.Text = "Quase que ótimo";
                    break;
                case 5:
                    lblMessage.Text = "Parabéns, 100% de acerto";
                    break;
                default:
                    break;
            }
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private async void btnRestart_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync(true);
        }
    }
}

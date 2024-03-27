using TrabalhoTaffeV2.Pages;

namespace TrabalhoTaffeV2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
            private async void lgnscreen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new at1());
        }

        private async void sobre(object sender, EventArgs e)
        {
           await DisplayAlert("Sobre este programa", "Este programa foi desenvolvido por 'Alan Przyvara', estudante de Análise e Desenvolvimento de Sistemas, com a ideia de desenvolver suas habilidades de coding de programas com interface visual usando .NET MAUI, durante seu 2 periodo da faculdade.", "Ok");
        }
    }
}
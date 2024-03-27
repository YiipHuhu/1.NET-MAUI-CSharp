using TrabalhoTaffeV2.Pages;

namespace TrabalhoTaffeV2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            
        }
    }
}
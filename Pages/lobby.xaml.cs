namespace TrabalhoTaffeV2.Pages;

public partial class lobby : ContentPage
{
	public lobby()
	{
		InitializeComponent();
	}

    private void nselect(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            int exercicio = int.Parse(button.CommandParameter.ToString());

            switch (exercicio)
            {
                case 1:
                        Navigation.PushAsync(new at1());
                    break;
                    case 2: 
                        Navigation.PushAsync(new at2());
                    break;
                    case 3:
                        Navigation.PushAsync(new at3());
                    break;
                    case 4:
                        Navigation.PushAsync(new at4());
                    break;
                    case 5:
                        Navigation.PushAsync(new at5());
                    break;
                    case 6:
                        Navigation.PushAsync(new at6());
                    break;
                    case 7:
                        Navigation.PushAsync(new at7());
                    break;
                    case 8:
                        Navigation.PushAsync(new at8());
                    break;
                    case 9:
                        Navigation.PushAsync(new at9());
                    break;
                    case 10:
                        Navigation.PushAsync(new at10());
                    break;
                    case 11:
                        Navigation.PushAsync(new at11());
                    break;


            }
        }
    }
}
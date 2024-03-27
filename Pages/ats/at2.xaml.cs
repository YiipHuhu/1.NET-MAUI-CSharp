namespace TrabalhoTaffeV2.Pages;

public partial class at2 : ContentPage
{
	public at2()
	{
		InitializeComponent();
	}

    private async void verific_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(idadeEntry.Text, out int idade))
        {
            if (idade <= 17)
            {
                resultado.Text = "Voc� � menor de idade";
            }

            else if (idade >= 70)
            {
                resultado.Text = "Voc� � idoso";
            }
            else if (idade >= 18 && idade <= 69)
            {
                resultado.Text = "Voc� � adulto";
            }
        }
        else
        {
            await DisplayAlert("Erro", "Digite uma idade v�lida", "OK");
        }
    }
}

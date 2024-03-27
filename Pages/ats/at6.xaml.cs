using Microsoft.Maui.Animations;

namespace TrabalhoTaffeV2.Pages;

public partial class at6 : ContentPage
{
	public at6()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string letra = letrae.Text.ToLower();

        if (char.IsDigit(letra[0]))
        {
            resultado.Text = "O valor digitado � um n�mero";
        }
        else if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            resultado.Text = "A letra digitada � uma vogal";
        }
        else if (char.IsLetter(letra[0]))
        {
            resultado.Text = "A letra digitada � uma consoante";
        }
        else
        {
            resultado.Text = "Valor inv�lido. Digite uma �nica letra ou n�mero.";
        }
    }
}

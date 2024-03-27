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
            resultado.Text = "O valor digitado é um número";
        }
        else if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            resultado.Text = "A letra digitada é uma vogal";
        }
        else if (char.IsLetter(letra[0]))
        {
            resultado.Text = "A letra digitada é uma consoante";
        }
        else
        {
            resultado.Text = "Valor inválido. Digite uma única letra ou número.";
        }
    }
}

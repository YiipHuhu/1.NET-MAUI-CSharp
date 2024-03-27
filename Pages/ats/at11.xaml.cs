namespace TrabalhoTaffeV2.Pages;

public partial class at11 : ContentPage
{
	public at11()
	{
		InitializeComponent();
	}
    private void CalcularMedia_Clicked(object sender, EventArgs e)
    {
        if (float.TryParse(Nota1Entry.Text, out float n1) &&
            float.TryParse(Nota2Entry.Text, out float n2) &&
            float.TryParse(Nota3Entry.Text, out float n3) &&
            float.TryParse(Nota4Entry.Text, out float n4))
        {
            if (n1 > 10 || n2 > 10 || n3 > 10 || n4 > 10)
            {
                ResultadoLabel.Text = "Digite notas de 0 a 10";
            }
            else
            {
                float media = (n1 + n2 + n3 + n4) / 4;
                ResultadoLabel.Text = $"A média das notas é: {media}";
            }
        }
        else
        {
            ResultadoLabel.Text = "Digite valores numéricos válidos.";
        }
    }
}

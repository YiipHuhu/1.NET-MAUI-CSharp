namespace TrabalhoTaffeV2.Pages;

public partial class at10 : ContentPage
{
	public at10()
	{
		InitializeComponent();
	}
    private void MostrarTabuada_Clicked(object sender, System.EventArgs e)
    {
        if (int.TryParse(TabuadaEntry.Text, out int tabuada))
        {
            ResultadoLabel.Text = $"Tabuada do {tabuada}:";

            for (int i = 1; i <= 10; i++)
            {
                ResultadoLabel.Text += $"\n{tabuada} x {i} = {tabuada * i}";
                ResultadoFrame.IsVisible = true;
            }
        }
        else
        {
            ResultadoLabel.Text = "Digite um número válido.";
        }
    }
}


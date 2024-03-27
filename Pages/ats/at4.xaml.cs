namespace TrabalhoTaffeV2.Pages;

public partial class at4 : ContentPage
{
	public at4()
	{
		InitializeComponent();
	}

    private  void converterclicked(object sender, EventArgs e)
    {
        string opcaoSelecionada = picker1.SelectedItem as string;
        float.TryParse(temperatura.Text, out float tempDigitado);

        if (opcaoSelecionada != null)
        {
            if (opcaoSelecionada == "Celsius para Fahrenheit")
            {
                float fahren = (tempDigitado * 9 / 5) + 32;
                resultadoLabel.Text = $"A temperatura em Fahrenheit é: {fahren}";
            }
            else if (opcaoSelecionada == "Fahrenheit para Celsius")
            {
                float celsius = (tempDigitado - 32) * 5 / 9;
                resultadoLabel.Text = $"A temperatura em Celsius é: {celsius}";
            }
        }
        else
        {
            resultadoLabel.Text = "Opção inválida";
        }
    }
}
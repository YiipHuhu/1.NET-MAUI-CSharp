namespace TrabalhoTaffeV2.Pages;

public partial class at3 : ContentPage
{
	public at3()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string operadorSelecionado = operacao.SelectedItem as string;
        double.TryParse(valor1.Text, out double n1Digitado);
        double.TryParse(valor2.Text, out double n2Digitado);
        double resultado = 0;

        if (operadorSelecionado != null)
        {
            char operador = operadorSelecionado[0];

            switch (operador)
            {
                case 'A':
                    resultado = n1Digitado + n2Digitado;
                    break;
                case 'S':
                    resultado = n1Digitado - n2Digitado;
                    break;
                case 'M':
                    resultado = n1Digitado * n2Digitado;
                    break;
                case 'D':
                    resultado = n1Digitado / n2Digitado;
                    break;
                case 'E':
                    resultado = Math.Pow(n1Digitado, n2Digitado);
                    break;
                case 'P':
                    resultado = (n1Digitado * n2Digitado) / 100;
                    break;
                default:
                    await DisplayAlert("Erro", "Operador inválido", "OK");
                    break;
            }

            resultadoo.Text = $"O resultado é: {resultado}";
        }
        else
        {
            await DisplayAlert("Erro", "Selecione um operador válido", "OK");
        }
    }

}

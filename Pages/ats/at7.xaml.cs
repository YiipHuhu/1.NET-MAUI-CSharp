namespace TrabalhoTaffeV2.Pages;

public partial class at7 : ContentPage
{
    public at7()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        {
            if (double.TryParse(txtValor.Text, out double valor) && double.TryParse(txtDesconto.Text, out double desconto))
            {
                double valorDesconto = valor * (desconto / 100);
                double valorFinal = valor - valorDesconto;

                lblResultado.Text = $"O valor do desconto �: R$ {valorDesconto:0.00}";
                lblResultado.Text = $"O valor final �: R$ {valorFinal:0.00}";

            }
            else
            {
                lblResultado.Text = "Valores inv�lidos. Digite valores num�ricos v�lidos.";

            }
        }
    }
}


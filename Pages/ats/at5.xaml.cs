namespace TrabalhoTaffeV2.Pages;

public partial class at5 : ContentPage
{
    public at5()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(txtPeso.Text, out double peso) && double.TryParse(txtAltura.Text, out double altura))
        {
            double imc = peso / (altura * altura);
            lblResultado.Text = $"Seu IMC �: {imc:F2}";

            // Avalia��o do IMC
            if (imc < 18.5)
            {
                lblResultado.Text += "\nVoc� est� abaixo do peso.";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                lblResultado.Text += "\nSeu peso est� saud�vel.";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                lblResultado.Text += "\nVoc� est� com sobrepeso.";
            }
            else
            {
                lblResultado.Text += "\nVoc� est� obeso.";
            }
        }
        else
        {
            lblResultado.Text = "Por favor, insira valores v�lidos.";
        }
    }
}

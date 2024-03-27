namespace TrabalhoTaffeV2.Pages;

public partial class at8 : ContentPage
{
    public at8()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //codigo copiado da antiga solu��o ja que pelo metodo novo o programa zerava a vida na primeira tentativa
        Random random = new Random();
        int sorteado = random.Next(0, 9);
        int vidas = 3;

        Label resultadoLabel3 = new Label
        {
            Text = "Bem-vindo ao Sorteador de N�meros! Escolha um n�mero de 0 a 9",
            FontSize = 23,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        Label tentativasLabel = new Label
        {
            Text = $"Tentativas restantes: {vidas}",
            FontSize = 18,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        Entry respostaEntry = new Entry
        {
            Placeholder = "Digite sua resposta",
            Keyboard = Keyboard.Numeric,
            MaxLength = 1,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        Button verificarButton3 = new Button
        {
            Text = "Verificar",
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        Button reiniciarButton = new Button
        {
            Text = "Reiniciar",
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.CenterAndExpand,
            IsEnabled = false // Inicialmente desabilitado at� que o jogo termine
        };

        verificarButton3.Clicked += (s, args) =>
        {
            if (int.TryParse(respostaEntry.Text, out int resposta))
            {
                if (resposta == sorteado)
                {
                    resultadoLabel3.Text = "Parab�ns! Voc� acertou o n�mero.";
                    tentativasLabel.Text = $"O n�mero sorteado foi: {sorteado}";
                    verificarButton3.IsEnabled = false;
                    reiniciarButton.IsEnabled = true; // Habilita o bot�o de reiniciar
                }
                else if (resposta < sorteado)
                {
                    resultadoLabel3.Text = "Tente novamente! O n�mero sorteado � maior.";
                    tentativasLabel.Text = $"Tentativas restantes: {--vidas}";
                }
                else if (resposta > sorteado)
                {
                    resultadoLabel3.Text = "Tente novamente! O n�mero sorteado � menor.";
                    tentativasLabel.Text = $"Tentativas restantes: {--vidas}";
                }

                if (vidas == 0)
                {
                    resultadoLabel3.Text = $"Voc� esgotou suas tentativas. O n�mero sorteado era {sorteado}.";
                    verificarButton3.IsEnabled = false;
                    reiniciarButton.IsEnabled = true; // Habilita o bot�o de reiniciar
                }
            }
            else
            {
                resultadoLabel3.Text = "Por favor, insira um n�mero v�lido.";
            }
        };

        reiniciarButton.Clicked += (s, args) =>
        {
            // Reinicia o jogo
            sorteado = random.Next(0, 9);
            vidas = 3;
            tentativasLabel.Text = $"Tentativas restantes: {vidas}";
            resultadoLabel3.Text = "Bem-vindo ao Sorteador de N�meros!";
            respostaEntry.Text = string.Empty;
            verificarButton3.IsEnabled = true;
            reiniciarButton.IsEnabled = false; // Desabilita o bot�o de reiniciar novamente
        };

        StackLayout jogoLayout = new StackLayout
        {
            Children = { resultadoLabel3, tentativasLabel, respostaEntry, verificarButton3, reiniciarButton },
            Padding = new Thickness(20)
        };

        await Navigation.PushModalAsync(new ContentPage
        {
            Content = jogoLayout
        });
       }
    }
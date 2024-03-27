namespace TrabalhoTaffeV2.Pages;

public partial class at9 : ContentPage
{
    int repeticao = 0;
    int somaidade = 0;
    public at9()
    {
        InitializeComponent();
    }
      private async void CalcularMediaClicked(object sender, System.EventArgs e)
        {

        int alunos = int.Parse(alunosEntry.Text);
            somaidade = 0;
            repeticao = 0;

            while (repeticao < alunos)
            {
                int idade = int.Parse(await DisplayPromptAsync("Idade", "Digite a idade dos alunos"));
                somaidade += idade;
                repeticao++;
            }

            int media = somaidade / alunos;
            resultadoLabel.Text = $"A média de idade é: {media}";
        }

        private async void AdicionarAlunoClicked(object sender, System.EventArgs e)
        {
            int novaidade = int.Parse(await DisplayPromptAsync("Idade", "Digite a idade do aluno"));
            somaidade += novaidade;
            int alunos = int.Parse(alunosEntry.Text) + 1;
            int media = somaidade / alunos;
            resultadoLabel.Text = $"A nova média é: {media}";

            var resposta = await DisplayAlert("Adicionar Aluno", "Deseja adicionar mais um aluno?", "Sim", "Não");

            if (!resposta)
            {
                resultadoLabel.Text += "\nObrigado por utilizar nosso programa!";
            }
        }
    }

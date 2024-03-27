using System;
using System.Collections.Generic;

namespace TrabalhoTaffeV2.Pages
{
    public partial class at1 : ContentPage
    {
        private List<Cadastro> listaDeCadastros = new List<Cadastro>(); //pra cria a lista de cadastro

        public at1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string nomeentry = usuariodig.Text;
            string senhaentry = senhadig.Text;

            bool credenciaisValidas = false;

            foreach (Cadastro cadastro in listaDeCadastros)
            {
                if (cadastro.Nome == nomeentry && cadastro.Senha == senhaentry)
                {
                    credenciaisValidas = true;
                    break;
                }
            }

            if (credenciaisValidas)
            {
                await DisplayAlert("Resultado", $"{nomeentry}, Logado com sucesso!", "OK");
                await Navigation.PushAsync(new lobby());
            }
            else
            {
                await DisplayAlert("Erro", $"{nomeentry} Credenciais inválidas ou talvez você nao possua um Login ainda.", "OK");
            }
        }

        private void cadastro_clicked(object sender, EventArgs e)
        {
            string nomeCadastro = usuariodig.Text;
            string senhaCadastro = senhadig.Text;

            if (!string.IsNullOrEmpty(nomeCadastro) && !string.IsNullOrEmpty(senhaCadastro))
            {
                if (!nomeCadastro.Contains(" ") && nomeCadastro.Length >= 3 && senhaCadastro.Length >= 6)
                {
                    Cadastro novoCadastro = new Cadastro
                    {
                        Nome = nomeCadastro,
                        Senha = senhaCadastro
                    };

                    listaDeCadastros.Add(novoCadastro);

                    // Limpa os campos após o cadastro
                    usuariodig.Text = "";
                    senhadig.Text = "";

                    DisplayAlert("Cadastro", "Cadastro realizado com sucesso!", "OK");
                }
                else
                {
                    DisplayAlert("Erro de Cadastro", "O nome de usuário deve possuir 3 caracteres e a senha 6, além de não podem conter espaços em branco.", "OK");
                }
            }
            else
            {
                DisplayAlert("Erro de Cadastro", "Preencha todos os campos antes de cadastrar.", "OK");
            }
        }


        public class Cadastro
        {
            public string Nome { get; set; }//pega o cad digitado
            public string Senha { get; set; }
        }
    }
}

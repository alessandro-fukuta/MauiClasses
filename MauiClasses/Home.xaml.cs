using MauiClasses.Models;

namespace MauiClasses;

public partial class Home : ContentPage
{
	// Instanciamento da Classe Animal gerando o objeto Doguinho
	// Doguinho agora é um objeto do tipo Animal.
	// Instanciando nesse local Doguinho fica publico e pode ser acessado por todos os metodos desse codigo

	Animal Doguinho = new Animal();

	// construtor padrao da classe Home
	// aqui é inicializado ao ser executado o nosso app
	public Home()
	{
		InitializeComponent();
		// abaixo Doguinho recebe alguns dados
		Doguinho.Nome = "Fred";
		Doguinho.Raca = "SND";
		Doguinho.Cor = "Caramelo";
		Doguinho.Valor = 100.00;
		Doguinho.Pedigree = "Não";

		// abaixo é executado alguns métodos do objeto Doguinho
		// que é do tipo (Animal)
		Doguinho.Beber();
		Doguinho.Latir();
		// txtNomeAnimal.Text = Doguinho.Estado;

	}

    private void btnCadastrar_Clicked(object sender, EventArgs e)
    {
		// ao clicao o botao ele executa aqui
		// Agora o objeto Doguinho recebe os dados que vem do XAML (TELA)
		Doguinho.Nome = txtNomeAnimal.Text;
		Doguinho.Raca = txtRaca.Text;
		Doguinho.Cor = txtCor.Text;
		Doguinho.Pedigree = txtPedigree.Text;
		Doguinho.Valor = double.Parse( txtValor.Text );

	
    }

    private void btnLatir_Clicked(object sender, EventArgs e)
    {
		// CLICANDO NO BOTAO LATIR
		// DOGUINHO EXECUTA O METODO LATIR

		Doguinho.Latir();
		DisplayAlert("Aviso", Doguinho.Estado, "OK");
    }
}
// namespace (projeto) MauiClasses
// Models (significa que está na pasta Models)

namespace MauiClasses.Models
{
    // classe publica Animal
    public class Animal
    {
        // proprieda do tipo string chamada Nome 
        // get -> significa que tem permissao pra pegar informações da propriedade
        // set -> significa que você pode enviar dados para a propriedade
        public string Nome { get; set; }
        public string Raca { get;  set; }
        public string Cor { get; set; }
        public string Pedigree { get; set; }

        // propriedade do tipo double chamada Valor
        public double Valor { get; set; }
        public string Estado { get; set; }

        // metodo construtor padrao da classe
        public Animal() { }

        // metodo construtor (sobrecarga) da classe
        public Animal(string nome, string raca)
        {
            Nome = nome;
            Raca = raca;
        }

        // exemplo de método 1
        public void Latir()
        {
            Estado = "Latindo";
        }

        // exemplo de método 2 - (void) signifca que não retorna nada
        public void Beber()
        {
            Estado = "Bebendo Água";
        }

    }
}



//Instanciado uma classe pessoa passando os paramentros
Pessoa pessoa = new Pessoa("Marcos", 30);

//Invocando o metodo apresentar, para imprimir a mensagem para o usuario
pessoa.Apresentar();


// Declarando uma classe Pessoa
public class Pessoa
{
    //Variaveis
    public string _nome;
    //Propriedades
    public string Nome { get; }
    public int Idade { get; set; }
    //Construtor
    public Pessoa(string nome, int idade)
    {
        //Armazenando o valor do paramento na variavel nome
        this._nome = nome;

        //Armazenando o valor do paramento na propriedade nome
        this.Nome = nome;

        //Armazenando o valor do paramento na propriedade idade
        this.Idade = idade;

    }

    //Metodos
    public void Apresentar()
    {
        Console.WriteLine($"Meu nome é {this.Nome} e minha idade é {this.Idade} anos");
    }
}
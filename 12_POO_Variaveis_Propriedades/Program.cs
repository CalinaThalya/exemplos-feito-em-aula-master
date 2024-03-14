

//Instanciado uma classe pessoa passando os paramentros
Pessoa pessoa = new Pessoa("Marcos", 30);


//Acessando e modificando valor da variavel _nome
pessoa._nome = "Carlos";
Console.WriteLine($"Nome que esta na variavel \"_nome\" é: {pessoa._nome}");

Console.WriteLine(); //Espaço entre os exemplos

//A propriedade nome nao pode ser modificada, pois nao tem o "Set" disponivel.
//pessoa.Nome = "Guilherme";

//Porem ela pode ser acessada (Lida)
Console.WriteLine($"Nome que esta na propriedade \"Nome\" é: {pessoa.Nome}");


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

        Console.WriteLine($"Meu nome é {nome} e minha idade é {idade} anos");
    }

    //Metodos
}
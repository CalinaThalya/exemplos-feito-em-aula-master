
//Instanciando uma classe Pessoa 
Pessoa pessoa_sem_parametros = new Pessoa();

//Instanciado uma classe pessoa passando os paramentros
Pessoa pessoa_com_parametros = new Pessoa("Marcos", 30);


//Obs: é possivel ter multiplos construtores desde que os parametros sejam diferentes


// Declarando uma classe Pessoa e imprimindo o uma mensagem no construtor
public class Pessoa
{
    //Variaveis
    //Propriedades
    //Construtor
    public Pessoa()
    {
        //Imprimindo a mensagem sem passagem de paramentros
        Console.WriteLine("Ola eu sou uma pessoa");
    }

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Meu nome é {nome} e minha idade é {idade} anos");
    }

    //Metodos
}
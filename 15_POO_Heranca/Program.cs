
//Instanciado classe Aluno, que herda todos os atributos e metodos de Pessoa
Aluno aluno = new Aluno("Marcos", 30, ".NET");

//Invocando o metodo apresentar, para imprimir a mensagem para o usuario que foi herdade da classe pessoa
aluno.Apresentar();


// Declarando uma classe Pessoa
public class Pessoa
{
    //Variaveis
    public string _nome;
    //Propriedades
    private string Nome { get; }
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

public class Aluno: Pessoa
{
    //Propriedade
    public string Curso { get; set; }

    //Construtor
    public Aluno(string nome, int idade, string curso) : base(nome, idade)
    {
        this.Curso = curso;
    }
}
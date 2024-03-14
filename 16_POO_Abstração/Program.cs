//Instanciando classe pessoa

//Descomente e veja que a pessoa nao pode ser mais instanciada
//Pessoa pessoa = new Pessoa("Marcos", 30);


//Instanciado classe Aluno, que herda todos os atributos e metodos de Pessoa
Aluno aluno = new Aluno("Alex", 18, ".NET");

//Utilizando o Protected para nao exibir a propriedade do lado de fora
//Descomente e veja o erro
//aluno.Nome;

//Invocando o metodo apresentar, para imprimir a mensagem para o usuario que foi herdade da classe pessoa
aluno.Apresentar();


// Declarando uma classe Pessoa
public abstract class Pessoa
{
    //Variaveis
    public string _nome;
    //Propriedades
    protected string Nome { get; } //Utilizando o Protected para proteger o metodo de se acessado do lado de fora quando a classe for Herdada
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

public class Aluno : Pessoa
{
    //Propriedade
    public string Curso { get; set; }

    //Construtor
    public Aluno(string nome, int idade, string curso) : base(nome, idade)
    {
        this.Curso = curso;
    }
}
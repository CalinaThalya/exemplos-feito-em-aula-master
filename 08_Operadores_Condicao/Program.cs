
//Estrutura do IF

using System.ComponentModel.Design;

//if (<Condicao Verdadeira>)
//{

//}
//else //Caso seja falsa a condição, cai no else
//{

//}

//Exemplo

int idade = 20;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}

Console.WriteLine(); //Espaço entre os exemplos

//Encadiando IF

int valor = 30;

if (valor >= 30)
{
    Console.WriteLine("Valor é maior ou igual a 30");
}
else if (valor >= 30)
{
    Console.WriteLine("Valor é maior ou igual a 20");
}
else
{
    Console.WriteLine("Valor informado é: " + valor);
}


Console.WriteLine(); //Espaço entre os exemplos


//Utilizando o switch para validar um valor
int andar = 2;
switch (andar)
{
    case 1:
        Console.WriteLine($"Você mora no primeiro andar");
        break;
    case 2:
        Console.WriteLine($"Você mora no segundo andar");
        break;
    default:
        Console.WriteLine($"Você mora no andar {andar}");
        break;
}
//for (inicialização; condição; incremento)
//{
//    // Bloco de código a ser repetido
//}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Número: {i}");
}

Console.WriteLine(); //Espaço entre os exemplos

//Pulando a vez 3 utilizando o "continue"
for (int i = 0; i < 5; i++)
{
    if(i == 3) continue;

    Console.WriteLine($"Número: {i}");
}

Console.WriteLine(); //Espaço entre os exemplos

//Parando quando a variavel de incremento chegar na posicao 3 utilizando o "break"
for (int i = 0; i < 5; i++)
{
    if (i == 3) break;

    Console.WriteLine($"Número: {i}");
}

Console.WriteLine(); //Espaço entre os exemplos

//Utilizando o Foreach

//string[] nome = new string[3];
//nome[2] = "Jose";

string[] nomes = { "Joao", "Maria", "Jose" };
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

Console.WriteLine(); //Espaço entre os exemplos
//Utilizando o while

//while (condição)
//{
//    // Bloco de código a ser repetido
//}

int j = 0;
while (j < 5)
{
    Console.WriteLine($"Número: {j}");
    j++;
}

Console.WriteLine(); //Espaço entre os exemplos
//Utilizando o do While

//do
//{
//    // Bloco de código a ser repetido
//} while (condição);
do
{
    Console.WriteLine($"Número: {j}");
    j++;
} while (j < 5);
//Constante nao pode ser modificada em tempo de execuçao, somente em tempo de programação

const int idade = 10;

//Descomente a linha e veja a IDE informar o erro quando tenta modificar o valor de uma constante
//idade = 11;

Console.WriteLine("[CONSTANTE] - Sua idade é: " + idade);


//Caso precise modificar o valor de uma variavel em tempo de execução, de preferencia em utilizar uma variaal
//que nao seja constante

int novaIdade = 20;

novaIdade = 21;

Console.WriteLine("[NORMAL] - Sua idade é: " + idade);

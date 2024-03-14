string nome = "João";
string sobrenome = "Silva";
string nomeCompleto = nome + " " + sobrenome;
Console.WriteLine("Nome completo: " + nomeCompleto);

//Interpolação
string produto = "Maçã";
decimal preco = 2.5m;
Console.WriteLine($"O preço da {produto} é {preco:C}.");

//Manipulação
string texto = "Olá, mundo!";
Console.WriteLine("Número de caracteres: " + texto.Length);
Console.WriteLine("Texto em maiúsculas: " + texto.ToUpper());
Console.WriteLine("Texto em minúsculas: " + texto.ToLower());
Console.WriteLine("Índice da palavra 'mundo': " + texto.IndexOf("mundo"));
Console.WriteLine("Substituição de 'mundo' por 'amigo': " + texto.Replace("mundo", "amigo"));

// See https://aka.ms/new-console-template for more information

char primeiraLetra = 'a'; // um caracter é interpretado com aspas simples
Console.WriteLine(primeiraLetra);

// dessa forma estamos manipulando de acordo com tabela ASCII
primeiraLetra = (char)65;
Console.WriteLine(primeiraLetra);
primeiraLetra += (char)1;
Console.WriteLine(primeiraLetra);

string titulo = "Alura cursos"; // da pra se utilizar o @ antes do texto para que possa se utilizar com quebras de linhas
Console.WriteLine(titulo);

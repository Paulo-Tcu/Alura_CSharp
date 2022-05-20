// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando Projeto 2\nExecutando variaveis !!!\n");

double salario = 1200.50;
int salarioEmInt = (int)salario;
Console.WriteLine($"Nosso salario em inteiro é: {salarioEmInt}");

long idade = 1300000000000000000; // é um tipo de variavel que suporta valores de 64bits
//int idade = 13000000000; dessa forma é alcançado o limite do tipo int, por isso seria necessário transformalo em long, inr suporta valores 32bits

// short seria para números menores, suporta valores de 16bits
short quantidadeProdutos = 15000;

float altura = 1.80f; // para usar o float o C# pensa que o valor é double se houver casas decimais, então por padrão do float deve-se usar f no final

Console.ReadLine();

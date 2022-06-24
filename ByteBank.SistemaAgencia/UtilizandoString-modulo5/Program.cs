using ByteBank.Modelos;
using ByteBank.Modelos.Clientes;
using System.Text.RegularExpressions;
using UtilizandoString_modulo5;

string url = "paginas?argumentos";

int indiceInterrogacao = url.IndexOf('?');  //Comando para localizar indice de um parametro

Console.WriteLine(indiceInterrogacao);

Console.WriteLine(url);
string argumentos = url.Substring(indiceInterrogacao+1);  // Comando para 'Recortar string'
Console.WriteLine(argumentos);
Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");

//Testando o Replace
string testeReplace = "ra";
testeReplace = testeReplace.Replace("r", "R"); 
Console.WriteLine(testeReplace);
testeReplace = testeReplace.Replace("a", "A");
Console.WriteLine(testeReplace);
Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");

//Testando StartWith, EndsWith e Contains
string verificarUrl = "http://www.bytebank.com/cambio";
Console.WriteLine(verificarUrl.StartsWith("http://www.bytebank.com"));
Console.WriteLine(verificarUrl.EndsWith("cambio"));
Console.WriteLine(verificarUrl.Contains("bytebank"));
Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");

//Expressões regulares
//string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
string padrao = "[0-9]{4,5}[-,' ']?[0-9]{4}";
string textoDeTeste = "Meu nome é Guilherme, me ligue em 94784 4546";

Match resultado = Regex.Match(textoDeTeste, padrao);

Console.WriteLine(resultado.Value);
Console.ReadLine();
// já o IsMatch retorna um boleano
Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");


try
{
    var extrator = new ExtratorUrl("http://www.bytebank.com/cambio?moedaOrigem=real?moedaDestino=dolar");

    Console.WriteLine($"Valor de Moeda Destino: {extrator.GetValor(("moedaDestino").ToLower())}");
    Console.WriteLine($"Valor de Moeda Origem: {extrator.GetValor(("moedaOrigem").ToLower())}");

}catch(Exception err)
{
    Console.WriteLine(err.Message);
}

Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
Cliente carlos_1 = new Cliente();
carlos_1.primeiro_nome = "Carlos";
carlos_1.cpf = "458.623.120-03";
carlos_1.profissao = "Designer";

Cliente carlos_2 = new Cliente();
carlos_2.primeiro_nome = "Carlos";
carlos_2.cpf = "458.623.120-03";
carlos_2.profissao = "Designer";

if (carlos_1.Equals(carlos_2))
{
    Console.WriteLine("São iguais!");
}
else
{
    Console.WriteLine("Não são iguais!");
}

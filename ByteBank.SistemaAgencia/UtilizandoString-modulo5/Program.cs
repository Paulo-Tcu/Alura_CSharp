using ByteBank.Modelos;
using UtilizandoString_modulo5;

string url = "paginas?argumentos";

int indiceInterrogacao = url.IndexOf('?');  //Comando para localizar indice de um parametro

Console.WriteLine(indiceInterrogacao);

Console.WriteLine(url);
string argumentos = url.Substring(indiceInterrogacao+1);  // Comando para 'Recortar string'
Console.WriteLine(argumentos);


try
{
    var extrator = new ExtratorUrl("http://www.bytebank.com/cambio?moedaOrigem=real?moedaDestino=dolar");

    Console.WriteLine(extrator.GetValor("moedaDestino"));

}catch(Exception err)
{
    Console.WriteLine(err.Message);
}
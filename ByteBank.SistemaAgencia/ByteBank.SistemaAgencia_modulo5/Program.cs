
using ByteBank.Modelos;
using ByteBank.Modelos.Clientes;

Cliente paulo = new Cliente();
ContaCorrente conta = new ContaCorrente(paulo, 1010,"1010-x", 1000);
Console.WriteLine(conta.Conta);

ContaCorrente contaTeste = new ContaCorrente(paulo, 10, " ", 1000);

//------------------------------Manipulação de String - modelo 6-------------------------



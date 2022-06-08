using bytebank;
using ClassesEObjetos;


Console.WriteLine("Bem vindo Banco ByteBank !!!");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "Paulo Cesar";
//conta1.conta = "123-x";
//conta1.numero_agencia = 1010;
//conta1.nome_agencia = "A que eu quiser";
//conta1.Saldo = 100;  //Definindo saldo através da propriedade Saldo com set

//Console.WriteLine($"Titular: {conta1.titular}");
//Console.WriteLine($"Conta: {conta1.conta}");
//Console.WriteLine($"Número da agência: {conta1.numero_agencia}");
//Console.WriteLine($"Nome da agência: {conta1.nome_agencia}");
//Console.WriteLine($"Saldo: {conta1.saldo}");

Roupa roupa1 = new Roupa();
roupa1.fabricante ="Moda Jeans";
roupa1.valor = 63.0;
Roupa roupa2 = roupa1;
roupa2.valor = roupa2.valor + 1000;
//Console.WriteLine(roupa1.valor);


//Console.WriteLine(roupa2.GetHashCode());
//Console.WriteLine(roupa1.GetHashCode());
//Console.WriteLine(conta1.GetHashCode());

//conta1.Sacar(50.333);
//conta1.Depositar(60.333);
//ContaCorrente conta2 = new ContaCorrente();
//conta2.conta = "123456";
//Console.WriteLine(conta1.Transferir(80,conta2));

Cliente cliente1 = new Cliente();
cliente1.primeiro_nome = "Paulo Cesar";
cliente1.sobrenome = "Araujo";
cliente1.cpf = "12345678901";
cliente1.profissao = "Developer";

ContaCorrente conta1 = new ContaCorrente(cliente1, "123-x", 12345, "Byte Bank", 0);  // atribuindo valores no ao obg conta1 por conta do construtor

// conta1.titular = cliente1; // Definindo o titular como o obj cliente1
Console.WriteLine(conta1.titular.primeiro_nome);
Console.WriteLine(cliente1.primeiro_nome);
Console.WriteLine(conta1.Saldo);  // Buscando valor de saldo através da propriedade Saldo pelo get

ContaCorrente conta2 = new ContaCorrente(cliente1, "123456-x", 123, "Byte Bank", 100.58);
Console.WriteLine(ContaCorrente.TotalContas);

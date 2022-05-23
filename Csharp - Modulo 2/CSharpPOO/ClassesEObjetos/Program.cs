using bytebank;


Console.WriteLine("Bem vindo Banco ByteBank !!!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Paulo Cesar";
conta1.conta = "123-x";
conta1.numero_agencia = 1010;
conta1.nome_agencia = "A que eu quiser";
conta1.saldo = 100;

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

conta1.Sacar(50.333);
conta1.Depositar(60.333);
ContaCorrente conta2 = new ContaCorrente();
conta2.conta = "123456";
Console.WriteLine(conta1.Transferir(80,conta2));
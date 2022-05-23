using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{

	public class ContaCorrente
	{
		public string titular;
		public string conta;
		public int numero_agencia;
		public string nome_agencia;
		public double saldo;

		/*
			Se adicionar um tipo antes do m�todo, significa que devemos usar a palavra reservada return
			J� no void ele apenas executa e n�o retorna nada
		*/
		public void Sacar(double valor)
        {
			if(valor > 0 && valor <= saldo)
            {
			
				saldo -= valor;
				Console.WriteLine($"O valor saquado foi de R${Math.Round(valor, 2)} e o novo saldo � de R${Math.Round(this.saldo, 2)}");
			}
            else
            {
				Console.WriteLine("Op��o Inv�lida, verifique o valor a ser saquado e saldo dispon�vel em conta !!!");
				throw new InvalidOperationException("Opera��o Inv�lida");
			}
        }
		public void Depositar(double valor)
        {
			if (valor > 0)
			{
				this.saldo += valor;
				Console.WriteLine($"Foi aceito o deposito de R${Math.Round(valor, 2)} e seu novo saldo � de R${Math.Round(this.saldo, 2)}");
			}
			else throw new InvalidOperationException("Opera��o inv�lida");	
        }

		public bool Transferir(double valor, ContaCorrente destino)
        {
			if(valor > 0 && valor <= saldo)
            {
				this.saldo -= valor;
				Console.WriteLine($"O valor de R${Math.Round(valor,2)} foi transferdo para Conta Corrente {destino.conta}\nSeu novo saldo � de R${Math.Round(this.saldo,2)}");
				return true;
            }
            else
            {
                Console.WriteLine("Opera��o inv�lida, o valor de seu saldo n�o foi movimentado.");
				return false;
            }
        }
	}
	public class Roupa
	{
		public int codigo;
		public string nome;
		public string fabricante;
		public double valor;
	}
}
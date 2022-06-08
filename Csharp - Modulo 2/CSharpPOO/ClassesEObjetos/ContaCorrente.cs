using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesEObjetos;

namespace bytebank
{

	public class ContaCorrente
	{
		public Cliente titular;
		public string conta;
		public int numero_agencia;
		public string nome_agencia;
		private double _saldo;
		int Teste { get; set; } // não definindo a privacidade e atribuindo get e set o C# adiciona ele como private
		public static int TotalContas { get; private set; }

		public ContaCorrente(Cliente titular, string conta, int numero_agencia, string nome_agencia, double saldo)
        {
			if (conta.Length != 0 && numero_agencia > 0 && nome_agencia.Length != 0 && saldo >= 0)
			{
				this.titular = titular;
				this.conta = conta;
				this.numero_agencia = numero_agencia;
				this.nome_agencia = nome_agencia;
				Saldo = saldo;
				TotalContas += 1;
			}
			else throw new Exception("Atríbuto inválido, revise os dados inseridos");
        }

		/*
			Se adicionar um tipo antes do método, significa que devemos usar a palavra reservada return
			Já no void ele apenas executa e não retorna nada
		*/
		public void Sacar(double valor)
        {
			if(valor > 0 && valor <= _saldo)
            {
			
				_saldo -= valor;
				Console.WriteLine($"O valor saquado foi de R${Math.Round(valor, 2)} e o novo saldo é de R${Math.Round(this._saldo, 2)}");
			}
            else
            {
				Console.WriteLine("Opção Inválida, verifique o valor a ser saquado e saldo disponível em conta !!!");
				throw new InvalidOperationException("Operação Inválida");
			}
        }
		public void Depositar(double valor)
        {
			if (valor > 0)
			{
				this.Saldo += valor;
				Console.WriteLine($"Foi aceito o deposito de R${Math.Round(valor, 2)} e seu novo saldo é de R${Math.Round(this.Saldo, 2)}");
			}
			else throw new InvalidOperationException("Operação inválida");	
        }

		public bool Transferir(double valor, ContaCorrente destino)
        {
			if(valor > 0 && valor <= Saldo)
            {
				this.Saldo -= valor;
				Console.WriteLine($"O valor de R${Math.Round(valor,2)} foi transferdo para Conta Corrente {destino.conta}\nSeu novo saldo é de R${Math.Round(this._saldo,2)}");
				return true;
            }
            else
            {
                Console.WriteLine("Operação inválida, o valor de seu saldo não foi movimentado.");
				return false;
            }
        }

		public double Saldo
        {
			get { return this._saldo; }
            set
            {
				if (value < 0) return;
				else _saldo = value;
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
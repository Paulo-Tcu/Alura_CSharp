using ByteBank_modulo5.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo5
{
	public class ContaCorrente
	{

		public Cliente Titular { get; private set; } 
        public string Conta { get; } //readonly é uma palavra reservada para permitir somente leitura
		public int Agencia { get; }
		private double _saldo;
		int Teste { get; set; } // não definindo a privacidade e atribuindo get e set o C# adiciona ele como private
		public static int TotalContas { get; private set; }
		public double TaxaOperacao { get; private set; }

		public ContaCorrente(Cliente titular,int numero_agencia, string conta, double saldo)
		{
			if(numero_agencia > 0 && conta.Length > 0 && titular != null)
				{
				Titular = titular;
				Agencia = numero_agencia;
				Conta = conta;
				Saldo = saldo;
				TotalContas++;
				TaxaOperacao = 30 / TotalContas;
            }
            else
            {
				if (titular == null) throw new ArgumentException("'ArgumentException': É preciso indicar um objeto válido da classe Cliente !!!", nameof(titular));		
				if (numero_agencia <= 0 ) throw new ArgumentException("'ArgumentException': É preciso indicar um valor maior que 0 para Agência !!!", nameof(numero_agencia));
				if (conta.Length == 0 || conta == null) throw new ArgumentException("'ArgumentException': É preciso indicar um valor válido para Conta!!!", nameof(conta));

			}
		}

        /*
			Se adicionar um tipo antes do método, significa que devemos usar a palavra reservada return
			Já no void ele apenas executa e não retorna nada
		*/

		public void Sacar(double valor)
		{
			if (valor > 0 && valor <= Saldo)
			{
				Saldo -= valor;
				Console.WriteLine($"Operação no valor de R${valor} efetuado com sucesso, saldo disponível: R${Saldo}");
			}
			else if (valor < 0)
			{
				Exception excecao = new ArgumentException("'ArgumentException' - Não é permitido argumento com valores negativos.", nameof(valor));
                Console.WriteLine($"Argumento inválido: {valor}");
				throw excecao;
			}

			else if (valor > Saldo) throw new SaldoInsuficienteException(valor, Saldo);

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

		public void Transferir(double valor, ContaCorrente destino)
		{
			Sacar(valor);
            Console.WriteLine($"Valor de R${valor} transferido com sucesso para {destino.Titular.primeiro_nome}");
		}
		public double Saldo
		{
			get { return this._saldo; }
			private set
			{
				if (value < 0) return;
				else _saldo = value;
			}
		}
	}
}

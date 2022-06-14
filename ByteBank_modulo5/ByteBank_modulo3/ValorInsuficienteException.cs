using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo3
{
    public class SaldoInsuficienteException : Exception
    {
        public double Valor { get;}
        public double Saldo { get;}

        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
        public SaldoInsuficienteException(double valor, double saldo) : this($"Saldo insuficiente para operação no valor de R$ {valor}\nSaldo em conta: R${saldo}")
        {
            Valor = valor;
            Saldo = saldo;
        }
    }
}

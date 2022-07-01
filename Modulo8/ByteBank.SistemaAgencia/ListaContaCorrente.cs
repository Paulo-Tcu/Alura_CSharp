using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(params ContaCorrente[] conta)
        {
            //If para validar se há necessidade de aumentar o tamanho do Array ou somente add um próximo valor
            if (_proximaPosicao > _itens.Length-1)
            {
                Console.WriteLine($"Aumentando array com tamanho {_itens.Length} para {_itens.Length*2}");
                ContaCorrente[] novoArray = new ContaCorrente[_itens.Length * 2];

                Array.Copy(_itens,novoArray,_itens.Length);
                _itens = novoArray;

                foreach (ContaCorrente contaCorrente in conta)
                {
                    _itens[_proximaPosicao] = contaCorrente;
                    Console.WriteLine($"Adicionado nova Conta Corrente na posição {_proximaPosicao} com numero da conta {_itens[_proximaPosicao].Numero}");
                    _proximaPosicao++;
                }

                //_itens[_proximaPosicao] = conta;
                //_proximaPosicao++;
            }
            else
            {
                foreach (ContaCorrente contaCorrente in conta)
                {
                    _itens[_proximaPosicao] = contaCorrente;
                    Console.WriteLine($"Adicionado nova Conta Corrente na posição {_proximaPosicao} com numero da conta {_itens[_proximaPosicao].Numero}");
                    _proximaPosicao++;
                }

                //_itens[_proximaPosicao] = conta;
                //_proximaPosicao++;
            }
        }
        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {

                if (_itens[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i+1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void GetPrintFullLista()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"Conta no índice {i}: numero agência: {conta.Agencia}, conta: {conta.Numero}");
            }
        }

        private Object GetItemIndice(int indice)
        {
            if(indice < 0 || indice >= _proximaPosicao)
            {
                return "Valor inválido";
            }
            return _itens[indice];
        }

        public ContaCorrente this[int indice]
        {
            get { return GetItemIndice(indice) as ContaCorrente; }
        }
    }
}

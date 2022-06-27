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

        public void Adicionar(ContaCorrente conta)
        {
            if (_proximaPosicao >= _itens.Length)
            {
                Console.WriteLine($"Aumentando array com tamanho {_itens.Length} para {_itens.Length*2}");
                ContaCorrente[] novoArray = new ContaCorrente[_itens.Length * 2];

                //for (int indice = 0; indice < _itens.Length; indice++)
                //{
                //    novoArray[indice] = _itens[indice];
                //}
                Array.Copy(_itens,novoArray,_itens.Length);
                _itens = novoArray;
                _itens[_proximaPosicao] = conta;
                _proximaPosicao++;
            }
            else
            {
                _itens[_proximaPosicao] = conta;
                _proximaPosicao++;
            }
            Console.WriteLine($"Adicionado nova Conta Corrente na posição {_proximaPosicao -1} com numero da conta {_itens[_proximaPosicao - 1].Numero}");
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

        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"Conta no índice {i}: numero {conta.Agencia} {conta.Numero}");
            }
        }
    }
}

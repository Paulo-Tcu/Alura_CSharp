using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Lista<T>
    {

        private T[] _itens;
        private int _proximaPosicao;

        public Lista(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(params T[] conta)
        {
            //If para validar se há necessidade de aumentar o tamanho do Array ou somente add um próximo valor
            if (_proximaPosicao > _itens.Length - 1)
            {
                Console.WriteLine($"Aumentando array com tamanho {_itens.Length} para {_itens.Length * 2}");
                T[] novoArray = new T[_itens.Length * 2];

                Array.Copy(_itens, novoArray, _itens.Length);
                _itens = novoArray;

                foreach (T contaCorrente in conta)
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
                foreach (T contaCorrente in conta)
                {
                    _itens[_proximaPosicao] = contaCorrente;
                    Console.WriteLine($"Adicionado nova Conta Corrente na posição {_proximaPosicao} com numero da conta {_itens[_proximaPosicao].Numero}");
                    _proximaPosicao++;
                }

                //_itens[_proximaPosicao] = conta;
                //_proximaPosicao++;
            }
        }
        public void Remover(T item)
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
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void GetPrintFullLista()
        {
            //for (int i = 0; i < _proximaPosicao; i++)
            //{
            //    ContaCorrente conta = _itens[i];
            //    Console.WriteLine($"Conta no índice {i}: numero {conta.Agencia} {conta.Numero}");
            //}
            int indice = 0;
            foreach (T conta in _itens)
            {
                Console.WriteLine($"Conta no índice {indice}: numero da agência: {conta.Agencia} e conta: {conta.Numero}");
                indice++;
            }
        }

        private T GetItemIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                return null;
            }
            return _itens[indice];
        }

        public T this[int indice]
        {
            get { return GetItemIndice(indice) as T; }
        }
    }
}

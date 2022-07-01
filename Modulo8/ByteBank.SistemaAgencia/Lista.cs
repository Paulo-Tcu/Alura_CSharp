using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {

        private T[] _itens;
        private int _proximaPosicao;
        public int ProximoIndice { get { return _proximaPosicao; } }

        public Lista(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(params T[] valor)
        {
            //If para validar se há necessidade de aumentar o tamanho do Array ou somente add um próximo valor
            if (_proximaPosicao > _itens.Length - 1 || valor.Length > _proximaPosicao)
            {
                Console.WriteLine($"Aumentando array com tamanho {_itens.Length} para {_itens.Length * 2}");
                T[] novoArray = new T[_itens.Length * 2];

                Array.Copy(_itens, novoArray, _itens.Length);
                _itens = novoArray;

                foreach (T i in valor)
                {
                    _itens[_proximaPosicao] = i;
                    _proximaPosicao++;
                }
            }
            else
            {
                foreach (T contaCorrente in valor)
                {
                    _itens[_proximaPosicao] = contaCorrente;
                    _proximaPosicao++;
                }
            }
            Console.WriteLine("Adicionado com sucesso");
        }
        public void RemoverItem(T item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                //For para comparar valor inserido e retornar o indice dentro do array
                if (_itens[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }
            //For para reordenar array
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
        }
        public void RemoverComIndice(int indice)
        {
            for (int i = indice; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
        }

        private T GetItemIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentException("Indice Invalido");
            }
            return _itens[indice];
        }

        public T this[int indice]
        {
            get { return GetItemIndice(indice); }
        }
        
    }
}

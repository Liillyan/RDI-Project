using System;
using System.Collections.Generic;

namespace ProjetoGeladeira
{
    public class Container
    {
        private List<ItemGeladeira> _itens;

        public Container()
        {
            _itens = new List<ItemGeladeira>();
            for (int i = 0; i < 4; i++)
            {
                _itens.Add(null);
            }
        }

        public void AdicionarItem(int posicao, string nome)
        {
            if (_itens[posicao] == null)
            {
                _itens[posicao] = new ItemGeladeira(nome);
                Console.WriteLine($"Item '{nome}' adicionado na Posição {posicao}.");
            }
            else
            {
                Console.WriteLine($"Posição {posicao} já está ocupada.");
            }
        }

        public void RemoverItem(int posicao)
        {
            if (_itens[posicao] != null)
            {
                Console.WriteLine($"Item '{_itens[posicao].Nome}' removido da Posição {posicao}.");
                _itens[posicao] = null;
            }
            else
            {
                Console.WriteLine($"Posição {posicao} já está vazia.");
            }
        }

        public void ImprimirItens(int numeroAndar, int numeroContainer)
        {
            for (int i = 0; i < _itens.Count; i++)
            {
                if (_itens[i] != null)
                {
                    Console.WriteLine($"Andar {numeroAndar}, Container {numeroContainer}, Posição {i}: {_itens[i].Nome}");
                }
            }
        }
    }
}

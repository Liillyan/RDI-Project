using System;
using System.Collections.Generic;

namespace ProjetoGeladeira
{
    public class Geladeira
    {
        private List<Andar> _andares;

        public Geladeira()
        {
            _andares = new List<Andar>();
            for (int i = 0; i < 3; i++) 
            {
                _andares.Add(new Andar());
            }
        }

        public void Inicializar()
        {
            _andares[0].Containers[0].AdicionarItem(0, "Tomate");
            _andares[0].Containers[1].AdicionarItem(1, "Cenoura");
            _andares[1].Containers[0].AdicionarItem(1, "Leite");
            _andares[2].Containers[1].AdicionarItem(2, "Presunto");
        }

        public void AdicionarElemento(int andar, int container, int posicao, string item)
        {
            _andares[andar].Containers[container].AdicionarItem(posicao, item);
        }

        public void RemoverElemento(int andar, int container, int posicao)
        {
            _andares[andar].Containers[container].RemoverItem(posicao);
        }

        public void ImprimirItens()
        {
            for (int i = 0; i < _andares.Count; i++)
            {
                _andares[i].ImprimirItens(i);
            }
        }
    }
}

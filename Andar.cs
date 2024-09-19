using System;
using System.Collections.Generic;

namespace ProjetoGeladeira
{
    public class Andar
    {
        public List<Container> Containers { get; private set; }

        public Andar()
        {
            Containers = new List<Container>();
            for (int i = 0; i < 2; i++)
            {
                Containers.Add(new Container());
            }
        }

        public void ImprimirItens(int numeroAndar)
        {
            for (int i = 0; i < Containers.Count; i++)
            {
                Containers[i].ImprimirItens(numeroAndar, i);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ProjetoGeladeira
{
    public class Andar : Armazenamento
    {
        public List<Container> Containers { get; private set; }

        public Andar()
        {
            Containers = new List<Container>();
            for (int i = 0; i < 2; i++) // 2 containers por andar
            {
                Containers.Add(new Container());
            }
        }

        public override void ImprimirItens(int numeroAndar)
        {
            for (int i = 0; i < Containers.Count; i++)
            {
                Containers[i].ImprimirItens(numeroAndar, i);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ProjetoGeladeira
{
    class Program
    {
        static void Main(string[] args)
        {
            Geladeira geladeira = new Geladeira();
            geladeira.Inicializar();
            geladeira.ImprimirItens();

            geladeira.RemoverElemento(0, 1, 1); 
            geladeira.ImprimirItens();

            geladeira.AdicionarElemento(0, 1, 0, "Alface"); 
            geladeira.ImprimirItens();
        }
    }
}

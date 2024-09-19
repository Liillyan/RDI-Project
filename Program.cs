using System;

class Program
{
    static void Main(string[] args)
    {
        string[,,] geladeira = new string[3, 2, 4];

        geladeira[0, 0, 0] = "Tomate"; 
        geladeira[0, 1, 1] = "Cenoura"; 
        geladeira[1, 0, 1] = "Leite"; 
        geladeira[2, 1, 2] = "Presunto"; 

        ImprimirItens(geladeira);
    }

    static void ImprimirItens(string[,,] geladeira)
    {
        for (int andar = 0; andar < geladeira.GetLength(0); andar++)
        {
            for (int container = 0; container < geladeira.GetLength(1); container++)
            {
                for (int posicao = 0; posicao < geladeira.GetLength(2); posicao++)
                {
                    if (geladeira[andar, container, posicao] != null)
                    {
                        Console.WriteLine($"Andar {andar}, Container {container}, Posição {posicao}: {geladeira[andar, container, posicao]}");
                    }
                }
            }
        }
    }
}

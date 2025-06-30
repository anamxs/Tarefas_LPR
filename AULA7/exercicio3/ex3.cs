
/*
Exercicio Proposto:
Crie um programa
que leia essa matriz e informe ao usuário a
distância entre duas cidades por ele
fornecidas.
O programa deve ficar repetindo até que o
usuário informe a mesma cidade como
origem e destino.
*/

 using System;

class Program
{
    static void Main()
    {
        string[] cidades = { "Vitória", "Belo Horizonte", "São Paulo", "Rio de Janeiro" };
        int[,] distancias = {
            { 0,   524, 881, 521 },
            { 524,   0, 586, 434 },
            { 881, 586,   0, 429 },
            { 521, 434, 429,   0 }
        };

        int origem, destino;

        do
        {
            Console.WriteLine("\nCidades disponíveis, escolha um numero:");
            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine($"{i} - {cidades[i]}");
            }

            Console.Write("\nInforme o número da cidade de origem: ");
            origem = int.Parse(Console.ReadLine());

            Console.Write("Informe o número da cidade de destino: ");
            destino = int.Parse(Console.ReadLine());

            if (origem < 0 || origem >= cidades.Length || destino < 0 || destino >= cidades.Length)
            {
                Console.WriteLine("Cidade inválida. Tente novamente.");
            }
            else if (origem == destino)
            {
                Console.WriteLine("\nOrigem e destino são a mesma cidade. Encerrando o programa.");
            }
            else
            {
                Console.WriteLine($"Distância entre {cidades[origem]} e {cidades[destino]}: {distancias[origem, destino]} km");
            }

        } while (origem != destino);
    }
}

/*
Exercicio Proposto:
VETOR: Construa um algoritmo
que leia 10 números inteiros. Depois
solicite para o usuário um número que ele
gostaria de pesquisar no vetor. Caso o
número exista no vetor, mostre em qual
posição (ou quais) ele aparece e quantas
ocorrências foram detectadas. 
*/

using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite um número para pesquisar no vetor: ");
        int numeroPesquisa = int.Parse(Console.ReadLine());

        int ocorrencias = 0;

        Console.WriteLine($"\nPosições em que o número {numeroPesquisa} aparece:");

        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] == numeroPesquisa)
            {
                Console.WriteLine($"- Posição {i}");
                ocorrencias++;
            }
        }
      
        if (ocorrencias > 0)
        {
            Console.WriteLine($"\nTotal de ocorrências: {ocorrencias}");
        }
        else
        {
            Console.WriteLine("\nO número não foi encontrado no vetor.");
        }
    }
}

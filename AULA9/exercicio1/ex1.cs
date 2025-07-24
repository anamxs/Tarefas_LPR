/*
Exercicio Proposto:
Construa uma lista de X nomes aleatórios
A saída deve ser mostrada em uma ou
mais linhas. Cada linha tem uma lista de
nomes ordenados por tamanho,
começando com o menor. Em cada linha,
só pode ser mostrado um nome de
determinado tamanho, e os demais
nomes com o mesmo tamanho devem ser
apresentados nas linhas seguintes. Você
deve seguir a ordem de digitação.
*/

using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> nomes = new List<string> { "duda", "ana", "maria", "ju", "carlos", "ana", };

        while (nomes.Count > 0)
        {
            int contarTamanhos = 1;
            for (int i = 1; i < nomes.Count; i++)
            {
                if (nomes[i].Length == contarTamanhos)
                {
                    Console.Write(nomes[i]);
                    nomes.RemoveAt(i);
                }
                else
                {
                    contarTamanhos++;
                }
            }
        }

    }


}
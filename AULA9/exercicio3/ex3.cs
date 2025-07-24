/*
Exercicio Proposto:
Construa um dicionário de X pares chave-valor
onde as chaves são nomes de pessoas e os
valores são suas respectivas idades.
Encontre e imprima todos os nomes de
pessoas com idade acima da média.
Encontre e imprima o nome da pessoa mais
velha e o nome da pessoa mais nova.
Remova todas as pessoas com idade igual a
um valor Y (fornecido pelo usuário) e imprima
o dicionário atualizado.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Quantas pessoas voce quer adicionar? ");
        int x = int.Parse(Console.ReadLine());

        Dictionary<string, int> pessoas = new();
        for (int i = 0; i < x; i++)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            pessoas[nome] = idade;
        }

        double media = 0;
        foreach (var p in pessoas)
            media += p.Value;
        media /= pessoas.Count;

        Console.WriteLine("\nPessoas com idade acima da média:");
        foreach (var p in pessoas)
            if (p.Value > media)
                Console.WriteLine(p.Key);

        string maisNova = "", maisVelha = "";
        int menor = int.MaxValue, maior = int.MinValue;

        foreach (var p in pessoas)
        {
            if (p.Value < menor)
            {
                menor = p.Value;
                maisNova = p.Key;
            }
            if (p.Value > maior)
            {
                maior = p.Value;
                maisVelha = p.Key;
            }
        }
        // Mostrar a mais nova e a mais velha 
        Console.WriteLine($"\nMais nova: {maisNova}");
        Console.WriteLine($"Mais velha: {maisVelha}");

        Console.Write("\nDigite a idade a ser removida: ");
        int y = int.Parse(Console.ReadLine());

        List<string> paraRemover = new();
        foreach (var p in pessoas)
            if (p.Value == y)
                paraRemover.Add(p.Key);

        foreach (string nome in paraRemover)
            pessoas.Remove(nome);

        // Mostrar o dicionario atualizado aqui
        Console.WriteLine("\nDicionário atualizado:");
        foreach (var p in pessoas)
            Console.WriteLine($"{p.Key}: {p.Value}");
    }
}

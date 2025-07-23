/*
Exercício Proposto:
Defina uma struct Produto que contenha
os seguintes campos: Nome, Codigo,
Preco e Quantidade. Crie um programa
que permita ao usuário inserir dados de 3
produtos e, em seguida, exiba o valor
total em estoque (considerando o preço e
a quantidade de cada produto).
*/

using System;
public struct Produto {
    public string Nome;
    public int Codigo;
    public float Preco;
    public int Quantidade;
}

class Program {
    static void Main() {
        Produto[] produtos = new Produto[3];
        float totalEstoque = 0;

        for (int i = 0; i < 3; i++) {
            Console.WriteLine($"Produto {i + 1}:");
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Código: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            produtos[i].Preco = float.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());

            totalEstoque += produtos[i].Preco * produtos[i].Quantidade;
            Console.WriteLine();
        }

        Console.WriteLine($"Valor total em estoque: R$ {totalEstoque:F2}");
    }
}

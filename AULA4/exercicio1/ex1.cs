/* Exercício Proposto: 
Fazer um programa para ler um número
inteiro, e depois dizer se este número é par
ou não.
*/

using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite um numero inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O numero e par!");
        } else {
            Console.WriteLine("O numero e impar.");
        }
    }  
}

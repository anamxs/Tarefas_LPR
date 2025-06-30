/*
Exercício Proposto:
FOR: Elabore um algoritmo que calcule a
soma de todos os números ímpares
múltiplos de 3 que se encontrem no
conjunto dos números de 50 a 500.
*/

using System;
class Program
{
    static void Main()
    {
        int soma = 0;

        for (int i = 50; i <= 500; i++)
        {
            if (i % 2 == 1 && i % 3 == 0) 
            {
                soma = soma + i;
            }
        }
        Console.WriteLine("A soma de todos os numeros impares é: " + soma);
    }
}


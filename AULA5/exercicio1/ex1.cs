/*
Exercício Proposto:
WHILE: Construa um algoritmo que calcule a
média aritmética de um conjunto de números
pares fornecidos pelo usuário. O usuário deve
fornecer primeiro a quantidade de números que
serão digitados, e em seguida, os números
considerados na média. O usuário pode digitar
números ímpares, que devem ser ignorados.
Por exemplo, no caso da tabela abaixo, o 5
informa que serão digitados 5 números (2 7 8 6
10), e para a média devem ser considerados
apenas os números pares (2, 8, 6 e 10)
ignorando o número 7 digitado
*/

using System;

class Program()
{
    static void Main(){
        Console.WriteLine("Digite a quantidade de numeros que vao ser digitados: ");
        int quantidade = int.Parse(Console.ReadLine());

    int contador = 0;
    int soma = 0;
    int parescontados = 0;

    while(contador < quantidade)
    {
        Console.WriteLine($"Digite o {contador + 1}º numero: ");
        int numeros = int.Parse(Console.ReadLine());

        if (numeros % 2 == 0 )
        {
            soma+=numeros;
            parescontados++;
        }
        contador++;
    }
     if (parescontados > 0)
        {
            double media = (double)soma / parescontados;
            Console.WriteLine($"Média dos números pares: {media:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum número par foi digitado.");
        }  
    }
}
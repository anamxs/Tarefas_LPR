/*
Exercício Proposto:
DO WHILE: Construa um algoritmo de adivinhação
de números. Com as linhas abaixo, o algoritmo
gerará um número inteiro aleatório de 1a 100:
O seu trabalho é elaborar um algoritmo em que o
usuário possa digitar números no console até
acertar o número inteiro aleatório valorInteiro, de 1 a
100. A cada chute, o programa deve responder com
“chutou alto”, “chutou baixo” ou “acertou”. Após
acertar, deve ser mostrado quantas tentativas foram
usadas para descobrir o número
*/

using System;
class Program
{
    static void Main()
    {
        Random numAleatorio = new Random();
        int valorSecreto = numAleatorio.Next(1, 101); 
        int tentativa;
        int tentativas = 0;

        Console.WriteLine("Tente adivinhar o número entre 1 e 100!");

        do
        {
            Console.Write("Digite seu palpite: ");
            tentativa = int.Parse(Console.ReadLine());
            tentativas++;

            if (tentativa < valorSecreto)
            {
                Console.WriteLine("Voce chutou baixo.");
            }
            else if (tentativa > valorSecreto)
            {
                Console.WriteLine("Chutou alto!!");
            }

        } while (tentativa != valorSecreto);

        Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativa(s).");
    }
}
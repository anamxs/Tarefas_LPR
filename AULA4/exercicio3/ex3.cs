/* Exercício Proposto:
Suponha que você está desenvolvendo um jogo
de RPG. Você é responsável por implementar a
mecânica de habilidades especiais para
diferentes classes de personagens. Cada classe
tem suas próprias habilidades especiais.
Crie um programa que permita ao jogador
escolher uma classe de personagem e, em
seguida, exiba suas habilidades especiais
correspondentes. 
*/

using System;

class Pogram()
{
    static void Main()
    {
        Console.WriteLine("Escolha a classe que deseja: ");
        Console.WriteLine("1 - Guerreira");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueiro");
        Console.WriteLine();  //pular linha
        Console.WriteLine("Agora, digite o numero da classe: ");
        
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Console.WriteLine("Habilidades da Guerreira: ");
                Console.WriteLine(" - Grito de guerra ");
                Console.WriteLine(" - Ataque poderoso ");
                Console.WriteLine(" - Defesa impenetravel ");
                break;

            case "2":
                Console.WriteLine("Habilidades do Mago: ");
                Console.WriteLine(" - Bola de fogo ");
                Console.WriteLine(" - Capuz invisivel");
                Console.WriteLine(" - Teletransporte ");
                break;

            case "3":
                Console.WriteLine("Habilidades do Arqueiro: ");
                Console.WriteLine(" - Armadilha ");
                Console.WriteLine(" - Velocidade ");
                Console.WriteLine(" - Arco poderoso");
                break;
            
            default:
                Console.WriteLine("A opcao que voce digitou e invalida.");
                break;
        }


    }
}
/*
Exercicio Proposto:
Desenvolva um programa em C# que
simule um sistema de seleção de heróis da
Marvel para uma equipe. O programa deve
ter as seguintes funcionalidades:
a) Cadastro de Heróis
b) Seleção de Equipe
c) Pontuação Total da Equipe
d) Exibição da Equipe
e) Menu
*/

using System;
public struct Heroi
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

class Program
{
    static Heroi[] herois = new Heroi[5];
    static int qtdHeroisCadastrados = 0;
    static int[] equipe = new int[3];
    static int qtdSelecionados = 0;

    static void Main()
    {
        menuPrincipal();
    }
    static void menuPrincipal()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n--- Menu Principal ---");
            Console.WriteLine("1. Cadastrar Herói");
            Console.WriteLine("2. Selecionar Equipe");
            Console.WriteLine("3. Exibir Equipe");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    break;
                case 2:
                    selecionarEquipe();
                    break;
                case 3:
                    exibirEquipe();
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 4);
    }

    static void cadastrarHeroi()
    {
        if (qtdHeroisCadastrados >= 5)
        {
            Console.WriteLine("O limite de heróis foi atingido!");
            return;
        }

        Heroi novo;
        Console.Write("Nome do herói: ");
        novo.Nome = Console.ReadLine();
        Console.Write("Poder do herói: ");
        novo.Poder = Console.ReadLine();
        Console.Write("Pontuação do herói: ");
        novo.Pontuacao = int.Parse(Console.ReadLine());

        herois[qtdHeroisCadastrados] = novo;
        qtdHeroisCadastrados++;

        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    static void selecionarEquipe()
    {
        if (qtdHeroisCadastrados < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis antes de montar a equipe.");
            return;
        }

        Console.WriteLine("\n--- Heróis disponíveis ---");
        for (int i = 0; i < qtdHeroisCadastrados; i++)
        {
            Console.WriteLine($"{i} - {herois[i].Nome} (Poder: {herois[i].Poder}, Pontuação: {herois[i].Pontuacao})");
        }

        qtdSelecionados = 0;
        while (qtdSelecionados < 3)
        {
            Console.Write($"Digite a escolha do {qtdSelecionados + 1}º herói da equipe: ");
            int Escolha = int.Parse(Console.ReadLine());

            if (Escolha >= 0 && Escolha < qtdHeroisCadastrados)
            {
                equipe[qtdSelecionados] = Escolha;
                qtdSelecionados++;
            }
            else
            {
                Console.WriteLine("Escolha inválida. Tente novamente.");
            }
        }

        Console.WriteLine("Equipe selecionada com sucesso!");
    }

    static int calcularPontuacaoTotal()
    {
        int total = 0;
        for (int i = 0; i < qtdSelecionados; i++)
        {
            total += herois[equipe[i]].Pontuacao;
        }
        return total;
    }

    static void exibirEquipe()
    {
        if (qtdSelecionados < 3)
        {
            Console.WriteLine("Equipe ainda não foi selecionada.");
            return;
        }

        Console.WriteLine("\n--- Equipe Selecionada ---");
        for (int i = 0; i < 3; i++)
        {
            Heroi h = herois[equipe[i]];
            Console.WriteLine($"{h.Nome} - Poder: {h.Poder} - Pontuação: {h.Pontuacao}");
        }

        int total = calcularPontuacaoTotal();
        Console.WriteLine($"Pontuação total da equipe: {total}");
    }
}

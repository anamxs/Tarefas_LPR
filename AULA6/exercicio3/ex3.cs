using System;
using System.Diagnostics;

class Program()
{
    static string nome1 = "", poder1 = "", nome2 = "", poder2 = "";
    static string nome3 = "", poder3 = "", nome4 = "", poder4 = "";
    static string nome5 = "", poder5 = "";
    static int pontos1 = 0, pontos2 = 0, pontos3 = 0, pontos4 = 0, pontos5 = 0;
    static int qtdHerois = 0;

    static string equipeNome1 = "", equipeNome2 = "", equipeNome3 = "";
    static string equipePoder1 = "", equipePoder2 = "", equipePoder3 = "";
    static int equipePontos1 = 0, equipePontos2 = 0, equipePontos3 = 0;

    static void Main(string[] args)
    {
        menuprincipal();
    }
    static void menuprincipal()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n-------MENU PRINCIPAL-------\n");
            Console.WriteLine("1 - Cadastrar Herói ");
            Console.WriteLine("2 - Selecionar Equipe ");
            Console.WriteLine("3 - Exibir Equipe ");
            Console.WriteLine("4 - Sair");
            Console.WriteLine(" EScolha uma opcao: ");
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
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 4);
    }
    static void cadastrarHeroi()
    {
        if (qtdHerois < 5)
        {
            Console.Write("Nome do herói: ");
            string nome = Console.ReadLine();
            Console.Write("Poder do herói: ");
            string poder = Console.ReadLine();
            Console.Write("Pontuação do herói: ");
            int pontos = int.Parse(Console.ReadLine());

            qtdHerois++;
            switch (qtdHerois)
            {
                case 1:
                    nome1 = nome; poder1 = poder; pontos1 = pontos;
                    break;

                case 2:
                    nome2 = nome; poder2 = poder; pontos2 = pontos;
                    break;
                case 3:
                    nome3 = nome; poder3 = poder; pontos3 = pontos;
                    break;
                case 4:
                    nome4 = nome; poder4 = poder; pontos4 = pontos;
                    break;

                case 5:
                    nome5 = nome; poder5 = poder; pontos5 = pontos;
                    break;

            }
            Console.WriteLine("Herois cadastrados com sucesso.");
        }

    }
    static void selecionarEquipe()
    {
        if (qtdHerois < 3)
        {
            Console.WriteLine("Cadastrar pelo menos 3 herois antes de formar equipe.");
            return;
        }

       Console.WriteLine("\n--- HERÓIS DISPONÍVEIS ---");
        if (nome1 != "") Console.WriteLine("1. " + nome1 + " - " + poder1 + " (" + pontos1 + ")");
        if (nome2 != "") Console.WriteLine("2. " + nome2 + " - " + poder2 + " (" + pontos2 + ")");
        if (nome3 != "") Console.WriteLine("3. " + nome3 + " - " + poder3 + " (" + pontos3 + ")");
        if (nome4 != "") Console.WriteLine("4. " + nome4 + " - " + poder4 + " (" + pontos4 + ")");
        if (nome5 != "") Console.WriteLine("5. " + nome5 + " - " + poder5 + " (" + pontos5 + ")");

        Console.WriteLine("\nSelecione 3 heróis para a equipe:");
        equipeNome1 = selecionarHeroi("Primeiro");
        equipeNome2 = selecionarHeroi("Segundo");
        equipeNome3 = selecionarHeroi("Terceiro");

        Console.WriteLine("Equipe selecionada com sucesso!");
    }
    static string selecionarHeroi(string ordem)
    {
        int escolha;
        string nome = "";
        do
        {
            Console.Write($"{ordem} herói (1-5): ");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    nome = nome1; equipePoder1 = poder1; equipePontos1 = pontos1;
                    break;
                case 2:
                    nome = nome2; equipePoder2 = poder2; equipePontos2 = pontos2;
                    break;
                case 3:
                    nome = nome3; equipePoder3 = poder3; equipePontos3 = pontos3;
                    break;
                case 4:
                    nome = nome4; equipePoder3 = poder4; equipePontos3 = pontos4;
                    break;
                case 5:
                    nome = nome5; equipePoder3 = poder5; equipePontos3 = pontos5;
                    break;
                default:
                    Console.WriteLine("Escolha inválida.");
                    break;
            }
        } while (escolha < 1 || escolha > 5 || nome == "");

        return nome;
    }
    
    static int calcularPontuacaoTotal()
    {
        return equipePontos1 + equipePontos2 + equipePontos3;
    }

    static void exibirEquipe()
    {
        if (equipeNome1 == "" || equipeNome2 == "" || equipeNome3 == "")
        {
            Console.WriteLine("Nenhuma equipe selecionada.");
            return;
        }

        Console.WriteLine("\n--- EQUIPE SELECIONADA ---");
        Console.WriteLine($"1. {equipeNome1} - Poder: {equipePoder1} - Pontos: {equipePontos1}");
        Console.WriteLine($"2. {equipeNome2} - Poder: {equipePoder2} - Pontos: {equipePontos2}");
        Console.WriteLine($"3. {equipeNome3} - Poder: {equipePoder3} - Pontos: {equipePontos3}");
        Console.WriteLine($"Pontuação total da equipe: {calcularPontuacaoTotal()}");
    }
}
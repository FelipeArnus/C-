using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Random rnd = new Random(); // declarando random

        Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
        Console.WriteLine("1 - Sim ou 0 - Não");

        if (Console.ReadKey().KeyChar == '1')
        {
            Console.WriteLine("\nEntão vamos começar...");
            Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");

            string PLAYER = Console.ReadLine();
            int player = int.Parse(PLAYER);

            int bot = rnd.Next(0, 3); // Gerar um número aleatório entre 0 e 2

            Console.WriteLine($"\nVocê escolheu: {player}");
            Console.WriteLine($"O bot escolheu: {bot}");

            if ((player == 0 && bot == 2) || (player == 1 && bot == 0) || (player == 2 && bot == 1))
            {
                Console.WriteLine("Parabéns, você ganhou!");
            }
            else if (player == bot)
            {
                Console.WriteLine("Empate!");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }
        }
        else
        {
            Console.WriteLine("\n👋 Tchau! Até a próxima");
        }
    }
}

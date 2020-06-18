using System;

namespace BlackjackEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World's coolest Blackjack game!");

            Blackjack game = new Blackjack();
            game.Init();
            game.Play();

            Console.ReadKey();
        }
    }
}

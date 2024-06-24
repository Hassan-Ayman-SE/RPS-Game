namespace RPS_Game
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors Game!");
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("Select game mode: ");
            Console.WriteLine("1. Normal Mode");
            Console.WriteLine("2. Hard Mode");
            int mode = int.Parse(Console.ReadLine());
            while (mode != 1 && mode != 2)
            {
                Console.WriteLine("Invalid input. Please enter\n 1 for Normal Mode\n 2 for Hard Mode.");
                mode = int.Parse(Console.ReadLine());
            }
            

            bool hardMode = mode == 2;
            RPSGame game = new RPSGame(playerName, hardMode);
            game.PlayGame();
        }
    }

}

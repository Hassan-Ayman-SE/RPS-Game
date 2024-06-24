using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace RPS_Game
{
    public class Player
    {
        //Props
        public string Name { get; set; }
        public int Score { get; set; }

        //Constructor
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
        //Method to allow user to choose move.
        public string ChooseMove()
        {
            Console.WriteLine($"{Name}, Plz enter your move (rock, paper, or scissors): ");
            string move = Console.ReadLine().ToLower();

            while (move != "rock" && move != "paper" && move != "scissors")
            {
                Console.WriteLine("Invalid move. Please enter rock, paper, or scissors: ");
                move = Console.ReadLine().ToLower();
            }

            return move;
        }
    }

}

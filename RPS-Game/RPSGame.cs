using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace RPS_Game
{
    public class RPSGame
    {
        //Attributes
        private Player player;
        private Player ai;
        private Random random;
        private bool hardMode;

        public Player Player { get; set; }
        public Player Ai { get; set; }
        public Random Random { get; set; }
        public bool HardMode { get; set; }
        //Constructor
        public RPSGame(string playerName, bool hardMode = false)
        {
            player = new Player(playerName);
            ai = new Player("AI");
            random = new Random();
            this.hardMode = hardMode;
        }

        // This method use it to paly round and after finish (scores = 3) --> Display Final Scores.
        public void PlayGame()
        {
            while (player.Score < 3 && ai.Score < 3)
            {
                PlayRound();
            }

            DisplayFinalScores();
        }

        //To play a round and invoke DisplayScores() after each round.
        private void PlayRound()
        {
            string playerMove = player.ChooseMove();
            string aiMove = hardMode ? GetHardModeAIMove(playerMove) : GetAIMove();

            Console.WriteLine($"AI chose: {aiMove}");

            string result = DetermineWinner(playerMove, aiMove);
            Console.WriteLine(result);

            DisplayScores();
        }
        //To get a random move for AI in (Normal Mode)
        public string GetAIMove()
        {
            int move = random.Next(3);
            return move switch
            {
                0 => "rock",
                1 => "paper",
                2 => "scissors",
                _ => "rock"
            };
        }
        //To get a random move for AI in (Hard Mode)
        public string GetHardModeAIMove(string playerMove)
        {
            return playerMove switch
            {
                "rock" => "paper",
                "paper" => "scissors",
                "scissors" => "rock",
                _ => GetAIMove()
            };
        }
        //Determine Winner in each round.
        public string DetermineWinner(string playerMove, string aiMove)
        {
            if (playerMove == aiMove)
            {
                return "It's a tie!";
            }

            if ((playerMove == "rock" && aiMove == "scissors") ||
                (playerMove == "paper" && aiMove == "rock") ||
                (playerMove == "scissors" && aiMove == "paper"))
            {
                player.Score++;
                return $"{player.Name} wins this round!";
            }
            else
            {
                ai.Score++;
                return "AI wins this round!";
            }
        }
        //Display scores after each round
        private void DisplayScores()
        {
            Console.WriteLine($"Scores: {player.Name} - ({player.Score}), AI - ({ai.Score})");
        }
        //Display final scores after finish the game.
        private void DisplayFinalScores()
        {
            Console.WriteLine("Game Over!");
            Console.WriteLine($"Final Scores: {player.Name} - ({player.Score}), AI - ({ai.Score})");

            if (player.Score > ai.Score)
            {
                Console.WriteLine($"{player.Name} wins the game!");
            }
            else
            {
                Console.WriteLine("AI wins the game!");
            }
        }
    }


}

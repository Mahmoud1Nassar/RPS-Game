using System;

namespace RPS_Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public static string ComputerMove()
        {
            string[] moves = { "rock", "paper", "scissor" };
            Random random = new Random();
            int aiMoveIndex = random.Next(moves.Length);
            return moves[aiMoveIndex];
        }

        public static string RPSPlayer()
        {
            Console.WriteLine("Rock, Paper, or Scissor?");
            return Console.ReadLine().ToLower();
        }

        public static string GetPlayerName()
        {
            Console.WriteLine("Enter Your Name:");
            return Console.ReadLine();
        }
    }
}

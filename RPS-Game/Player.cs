using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
   public static class Player
    {

        public static string computerMove() {
            string[] moves = { "rock", "paper", "scissor" };
            Random random = new Random();
            int aiMoveIndex = random.Next(moves.Length);
            string aiMove = moves[aiMoveIndex];
            return aiMove;
        }

        public static string RPSPlayer() {
            Console.WriteLine("Rock,Paper or Scissor?");
            string playerMove = Console.ReadLine().ToLower();
            return playerMove;
            
        }
        
        public static string playerData() {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            return name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    internal class RPSGame
    {
        public static void PlayerVSComputer() {
            Console.WriteLine("Welcome to our game RPS you need to choose between (rock, paper, scissor)");
            Player.playerData();
           
            int playerScore = 0, AiScore = 0, rounds = 3;
            do
            {
                string AiMove = Player.computerMove();
                string playerMove = Player.RPSPlayer();

                if ((AiMove == "rock" && playerMove == "scissor")
                        || (AiMove == "paper" && playerMove == "rock")
                            || (AiMove == "scissor" && playerMove == "paper")) {
                    AiScore++;
                    rounds--;
                    Console.WriteLine($"Ai Won this Round with {AiMove}" );
                }
                 else if ((playerMove == "rock" && AiMove == "scissor") 
                    || (playerMove == "paper" && AiMove == "rock") 
                        || (playerMove == "scissor" && AiMove == "paper"))
                {
                    playerScore++;
                    rounds--;
                    Console.WriteLine($"You Won this Round with {playerMove}");
                }
                else
                {
                    Console.WriteLine("This Round is Tie");
                    rounds--;
                }

            } while (rounds != 0);

            if (AiScore > playerScore) Console.WriteLine("Ai Won the Game");
            else if (playerScore > AiScore) Console.WriteLine("You Won this Game");
            else Console.WriteLine("This game is Tie");
        }
    }
}

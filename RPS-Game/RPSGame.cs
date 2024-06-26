using System;

namespace RPS_Game
{
    public class RPSGame
    {
        public Player Player { get; private set; }
        public Player AI { get; private set; }
        public int Rounds { get; private set; } = 3;

        public RPSGame(Player player, Player ai)
        {
            Player = player;
            AI = ai;
        }

        public void PlayerVSComputer(Func<string> computerMoveProvider)
        {
            while (Rounds > 0)
            {
                string aiMove = computerMoveProvider();
                string playerMove = Player.RPSPlayer();

                if ((aiMove == "rock" && playerMove == "scissor")
                        || (aiMove == "paper" && playerMove == "rock")
                            || (aiMove == "scissor" && playerMove == "paper"))
                {
                    AI.Score++;
                    Console.WriteLine($"AI won this round with {aiMove}");
                }
                else if ((playerMove == "rock" && aiMove == "scissor")
                        || (playerMove == "paper" && aiMove == "rock")
                        || (playerMove == "scissor" && aiMove == "paper"))
                {
                    Player.Score++;
                    Console.WriteLine($"You won this round with {playerMove}");
                }
                else
                {
                    Console.WriteLine("This round is a tie.");
                }

                Rounds--;
            }

            if (AI.Score > Player.Score)
                Console.WriteLine("AI won the game!");
            else if (Player.Score > AI.Score)
                Console.WriteLine("You won the game!");
            else
                Console.WriteLine("The game is a tie.");
        }
    }
}

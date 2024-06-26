using System;

namespace RPS_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Player player = new Player(Player.GetPlayerName());
            Player ai = new Player("AI");

            
            RPSGame game = new RPSGame(player, ai);

           
            game.PlayerVSComputer(Player.ComputerMove);
        }
    }
}

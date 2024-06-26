using System;
using Xunit;
using RPS_Game;

namespace RPSGameTests
{
    public class PlayerTests
    {
        [Fact]
        public void ComputerMove_ShouldReturn_ValidMove()
        {
            string[] validMoves = { "rock", "paper", "scissor" };
            string result = Player.ComputerMove();
            Assert.Contains(result, validMoves);
        }

        [Fact]
        public void PlayerData_ShouldReturn_Name()
        {
            var input = "TestName";
            var stringReader = new System.IO.StringReader(input);
            Console.SetIn(stringReader);
            string result = Player.GetPlayerName();
            Assert.Equal(input, result);
        }

        [Fact]
        public void RPSPlayer_ShouldReturn_PlayerMove()
        {
            var input = "rock";
            var stringReader = new System.IO.StringReader(input);
            Console.SetIn(stringReader);
            string result = Player.RPSPlayer();
            Assert.Equal(input, result);
        }

        [Fact]
        public void PlayerVSComputer_ShouldUpdateScores()
        {
            var stringReader = new System.IO.StringReader("TestName\nrock\nrock\nrock\n");
            Console.SetIn(stringReader);

            Player player = new Player("TestName");
            Player ai = new Player("AI");
            RPSGame game = new RPSGame(player, ai);

            // Mock computer move sequence: rock, paper, scissor
            var moves = new Queue<string>(new[] { "scissor", "rock", "paper" });
            string MockComputerMove() => moves.Dequeue();

            game.PlayerVSComputer(MockComputerMove);

            // Check that scores have been updated
            Assert.True(player.Score > 0 || ai.Score > 0, "Scores should be updated after the game.");
        }
    }
}

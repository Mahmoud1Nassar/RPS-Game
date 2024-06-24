using System.Numerics;
namespace RPSGameTests;
using RPS_Game;


    public class UnitTest1
    {
        [Fact]
        public void ComputerMove_ShouldReturn_ValidMove()
        {
           
            string[] validMoves = { "rock", "paper", "scissor" };
            string result = Player.computerMove();
            Assert.Contains(result, validMoves);
        }

    [Fact]
    public void PlayerData_ShouldReturn_Name()
    {
        var input = "TestName";
        var stringReader = new System.IO.StringReader(input);
        Console.SetIn(stringReader);
        string result = Player.playerData();
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
}


using Xunit;

namespace RPS_GameTests
{

    public class RPSGameTests
    {
        [Fact]
        public void TestDetermineWinner_PlayerWins()
        {
            RPSGame game = new RPSGame("TestPlayer");
            string result = game.DetermineWinner("rock", "scissors");
            Assert.Equal("TestPlayer wins this round!", result);
        }

        [Fact]
        public void TestDetermineWinner_AIWins()
        {
            RPSGame game = new RPSGame("TestPlayer");
            string result = game.DetermineWinner("rock", "paper");
            Assert.Equal("AI wins this round!", result);
        }

        [Fact]
        public void TestDetermineWinner_Tie()
        {
            RPSGame game = new RPSGame("TestPlayer");
            string result = game.DetermineWinner("rock", "rock");
            Assert.Equal("It's a tie!", result);
        }

        [Fact]
        public void TestScoreUpdate_PlayerWins()
        {
            RPSGame game = new RPSGame("TestPlayer");
            game.DetermineWinner("rock", "scissors");
            Assert.Equal(1, game.player.Score);
            Assert.Equal(0, game.ai.Score);
        }

        [Fact]
        public void TestScoreUpdate_AIWins()
        {
            RPSGame game = new RPSGame("TestPlayer");
            game.DetermineWinner("rock", "paper");
            Assert.Equal(0, game.player.Score);
            Assert.Equal(1, game.ai.Score);
        }

        [Fact]
        public void TestHardModeAI_MovePrediction()
        {
            RPSGame game = new RPSGame("TestPlayer", hardMode: true);
            string playerMove = "rock";
            string aiMove = game.GetHardModeAIMove(playerMove);
            Assert.Equal("paper", aiMove);
        }

        [Fact]
        public void TestHardModeAI_ScoreUpdate()
        {
            RPSGame game = new RPSGame("TestPlayer", hardMode: true);
            string result = game.DetermineWinner("rock", game.GetHardModeAIMove("rock"));
            Assert.Equal("AI wins this round!", result);
            Assert.Equal(0, game.player.Score);
            Assert.Equal(1, game.ai.Score);
        }
    }

}
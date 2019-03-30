using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace tictactoeTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestForPlayerWin()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            game.Board.GameBoard = new string[,]
            {
                {"X", "2", "3"},
                {"4", "X", "6"},
                {"7", "8", "X"},
            };
            Assert.True(game.CheckForWinner(game.Board));
        }

        [Fact]
        public void TestForPlayerSwitch()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
        }


        [Fact]
        public void TestForPlayerChoiceConfirmPosition()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
        }

        [Fact]
        public void TestForDrawCondition()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
        }
    }
}

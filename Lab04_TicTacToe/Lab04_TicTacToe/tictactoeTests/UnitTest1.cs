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

            game.PlayerOne.IsTurn = true;
            game.SwitchPlayer();
            Assert.Equal(game.PlayerTwo, game.NextPlayer());
        }


        [Fact]
        public void TestForPlayerChoiceConfirmPosition()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            Position posi = new Position(0, 0);

            //This should work, couldnt figure it out. Dan helped me break it out.
            //Assert.Equal(posi, Player.PositionForNumber(1));

            Assert.Equal(posi.Row, Player.PositionForNumber(1).Row);
            Assert.Equal(posi.Column, Player.PositionForNumber(1).Column);
        }

        [Fact]
        public void TestForDrawCondition()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            game.Board.GameBoard = new string[,]
{
                {"X", "O", "O"},
                {")", "X", "X"},
                {"X", "X", "O"},
};
            Assert.False(game.CheckForWinner(game.Board));
        }
    }
}

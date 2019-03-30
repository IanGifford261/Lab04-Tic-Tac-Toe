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
        }

        [Fact]
        public void TestForPlayerSwitch()
        {
            
        }


        [Fact]
        public void TestForPlayerChoiceConfirmPosition()
        {

        }

        [Fact]
        public void TestForDrawCondition()
        {

        }
    }
}

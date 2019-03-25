using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    public class Program
    {

        static void Main(string[] args)
        {
            PlayGame();
        }
        /// <summary>
        /// 
        /// </summary>
        static void PlayGame()
        {
            Console.Clear();
            Console.WriteLine(" Welcome To Tic Tac Toe");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Player One, enter your name");
            Console.WriteLine(" ");

            string p1 = Console.ReadLine();

            Player player1 = new Player
            {

                Name = p1,
                Marker = "X",
                IsTurn = true
            };

            Console.WriteLine(" Player Two, enter your name");
            string p2 = Console.ReadLine();

            Player player2 = new Player
            {
                Name = p2,
                Marker = "O",
                IsTurn = false
            };

            Console.Clear();
            Console.WriteLine(" Get ready to start");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Game game = new Game(player1, player2);

            Player winner = game.Play();
            if (!(winner is null))
            {
                Console.WriteLine($"{winner.Name} Wins this game! yay.");
            } else
            {
                Console.WriteLine("Draw");
            }

            // TODO: Setup your game here. Create an introduction. 
            // Create your players, and instantiate your Game class. 
            // output to the console the winner
        }
    }
}

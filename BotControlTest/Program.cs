using System;
using System.Windows;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //GameMachine GM = new GameMachine();
            int xx = 0;
            xx = Convert.ToInt32(Console.ReadLine());

            GameMachine(xx);
        }

        public static void GameMachine(int x)
        {

            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };
            try
            {
                Console.WriteLine(games[x]);
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
        }        
        
    }
}

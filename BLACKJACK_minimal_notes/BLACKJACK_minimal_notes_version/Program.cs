using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Creating the game TwentyOne aka BlackJack
// Refactoring this code -- this version has minimal notes/comments -- the orginal version has 'instructions' -- this is the 'clean' version
namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Vik's BlackJack Game. To play, enter your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("How much money did you bring for your starting amount?");
            int playerBank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of BlackJack?", playerName);
            string playerAnswer = Console.ReadLine().ToLower();

            if (playerAnswer == "yes" || playerAnswer == "yeah" || playerAnswer == "yep" || playerAnswer == "y" || playerAnswer == "ya" || playerAnswer == "yup")
            {
                Player playerObject = new Player(playerName, playerBank);
                Game game = new TwentyOneGame();
                game += playerObject;
                playerObject.isActivelyPlaying = true;
                while (playerObject.isActivelyPlaying && playerObject.Balance > 0)
                {
                    game.Play();
                }
                game -= playerObject;
                Console.WriteLine("Thanks for playing!");
            }

            Console.WriteLine("Goodbye for now.");
            Console.Read();
        }
    }
}
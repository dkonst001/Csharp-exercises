using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_7_3

{
    public enum Rank {DEUCE,THREE,FOUR,FIVE,SIX,SEVEN,EIGHT,NINE,TEN,JACK,QUEEN,KING,ACE}
    public enum Suit {DIAMONDS,SPADES,HEARTS,CLUBS}

    class Program
    {
        static void Main(string[] args)
        {
            string[] playersNames = new string[4];

            playersNames[0] = "Moshe";
            playersNames[1] = "Avi";
            playersNames[2] = "Yossi";
            playersNames[3] = "Shay";

            Game game = new Game(playersNames,5);

            PrintGame(game, "Before");

            game.PlayGame();

            PrintGame(game, "After");

            game.NewGame(6);

            PrintGame(game, "Before");

            game.PlayGame();

            PrintGame(game, "After");
        }

        static void PrintGame(Game game, string stateGame)
        {
            Console.WriteLine("{0} playing the game:\r\n", stateGame);
            Console.WriteLine(game.ToString());
            Console.ReadLine();
        }      
    }
}

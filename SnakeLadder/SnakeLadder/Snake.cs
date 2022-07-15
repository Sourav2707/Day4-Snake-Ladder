using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Snake
    {
        public void Ladder()
        {
            int win = 100;
            Player player1 = new Player();
            Player player2 = new Player();
            Console.WriteLine($"The starting position of player is {player1.position}");
            Console.WriteLine("\n");
            while ((player1.position < win) || (player2.position < win))
            {
                Console.WriteLine("Player 1:");
                player1.Game();
                if ((player1.option == 1) && (player1.position < win))
                {
                    Console.WriteLine("Player 1:");
                    player1.Game();
                }
                if (player1.position > win)
                {
                    player1.position = 0;
                }
                if (player1.position == win)
                {
                    Console.WriteLine("Player 1 won the game");
                    break;
                }
                Console.WriteLine("Player 2:");
                player2.Game();
                if ((player2.option == 1) && (player2.position < win))
                {
                    Console.WriteLine("Player 2:");
                    player2.Game();
                }
                if (player2.position > win)
                {
                    player2.position = 0;
                }
                if (player2.position == win)
                {
                    Console.WriteLine("Player 2 won the game");
                    break;
                }
            }
        }
    }
}

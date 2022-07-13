using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this program may take 5-10 minutes to show the result
namespace SnakeLadder
{
    public class Snake
    {
        public const int ladder = 1, snake = 2;
        public void Ladder()
        {
            Player1 player1 = new Player1();
            Console.WriteLine($"The starting position of player is {player1.position1}");
            Console.WriteLine("\n");
            while ((player1.position1 < player1.win) || (player1.position2 < player1.win))
            {
                roll++;
                Console.WriteLine("Player 1: ");
                player1.play();
                Console.WriteLine($"The number got by dice roll is {player1.dice1}");
                Console.WriteLine($"The player position is {player1.position1}");
                Console.WriteLine("Player 2:");
                player1.play();
                Console.WriteLine($"The number got by dice roll is {player1.dice2}");
                Console.WriteLine($"The player position is {player1.position2}");
            }
        }
        public class Player1
        {
            public int position1 = 0, position2 = 0;
            public int option = 0;
            public int win = 100;
            public int dice1 = 0, dice2 = 0;
            public void play()
            {
                Random random1 = new Random();
                dice1 = random1.Next(1, 7);
                Random random2 = new Random();
                dice2 = random2.Next(1, 7);
                Random random3 = new Random();
                option = random3.Next(0, 3);
                switch (option)
                {
                    case ladder:
                        position1 += dice1;
                        position2 += dice2;
                        Console.WriteLine("The player climbed the ladder");
                        break;
                    case snake:
                        position1 -= dice1;
                        position2 -= dice2;
                        if ((position1 < 0) || (position2 < 0))
                        {
                            Console.WriteLine("The player bit by snake");
                            position1 = 0;
                            position2 = 0;
                        }
                        else
                        {
                            Console.WriteLine("The player bit by snake");
                        }
                        break;
                    default:
                        Console.WriteLine($"No play");
                        break;
                }
                if ((position2 > win) || (position1 > win))
                {
                    position2 = 0;
                    position1 = 0;
                }
            }
        }
    }
}
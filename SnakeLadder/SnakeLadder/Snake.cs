using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Snake
    {
        public const int ladder = 1, snake = 2;
        public void Ladder()
        {
            int position1 = 0;
            int dice = 0;
            int roll = 0;
            Console.WriteLine($"The starting position of player is {position1}");
            Console.WriteLine("\n");
            do
            {
                roll++;
                Random random = new Random();
                dice = random.Next(1, 7);
                Console.WriteLine($"The number got by dice roll is {dice}");
                Random random2 = new Random();
                int option = random2.Next(0, 3);
                switch (option)
                {
                    case ladder:
                        position1 += dice;
                        Console.WriteLine("The player climbed the ladder");
                        break;
                    case snake:
                        position1 -= dice;
                        if (position1 < 0)
                        {
                            Console.WriteLine("The player bit by snake");
                            position1 = 0;
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
                if (position1 > 100)
                {
                    position1 = 0;
                }
                Console.WriteLine($"The player position is {position1}");
                Console.WriteLine($"The dice has been rolled {roll} times till now");
                Console.WriteLine("\n");
            } while (position1 < 100);
            Console.WriteLine($"The dice has been rolled {roll} times to reach 100");
        }
    }
}

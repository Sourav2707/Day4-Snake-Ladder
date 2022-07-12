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
            Console.WriteLine($"The starting position of player is {position1}");
            Console.WriteLine("\n");
            do
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
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
                Console.WriteLine($"The player position is {position1}");
                Console.WriteLine("\n");
                if (position1 > 100)
                {
                    position1 = 0;
                }
            } while (position1 < 100);
        }
    }
}

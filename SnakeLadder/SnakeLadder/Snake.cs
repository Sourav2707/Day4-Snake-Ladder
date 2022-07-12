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
            int position = 0;
            Console.WriteLine($"The starting position of player is {position}");
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine($"The number got by dice roll is {dice}");
                Random random2 = new Random();
                int option = random2.Next(0, 3);
                switch (option)
                {
                    case ladder:
                        position += dice;
                        Console.WriteLine("The player climbed the ladder");
                        break;
                    case snake:
                        position -= dice;
                        if(position < 0)
                        {
                        Console.WriteLine("The player bit by snake");
                        position = 0;
                        }
                        break;
                    default:
                        position = 0;
                        Console.WriteLine($"No play");
                        break;
                }
            Console.WriteLine($"The player position is {position}");
        }
    }
}

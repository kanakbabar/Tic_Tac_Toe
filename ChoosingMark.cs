using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class ChoosingMark
    {
        public static void choosingXorO()
        {
            Console.WriteLine("Choose 1 for 'X' or Choose 2 for 'O' as your mark");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("playerMark = 'X'");
                    Console.WriteLine("computerMark = 'O'");
                    break;
                case 2:
                    Console.WriteLine("playerMark = 'O'");
                    Console.WriteLine("computerMark = 'X'");
                    break;
                default:
                    Console.WriteLine("Your input is invalid");
                    break;
            }
        }
    }
}

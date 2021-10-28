using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   public class TicTacToe
    {
        public static char[] element;

        public static void CreatBoard()
        {
            element = new char[10];
            for (int i = 1; i < 10; i++)
            {
                element[i] = ' ';
            }
            Console.WriteLine("Empty board are created .");
        }
    }
}

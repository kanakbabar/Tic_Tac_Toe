using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public static object element;

        public static void ShowBoard()
        {
            element = new char[10];
            Console.WriteLine("\n  " + element + " | " + element + " | " + element + " ");
            Console.WriteLine(" ----------- ");
            Console.WriteLine("  " + element + " | " + element + " | " + element + " ");
            Console.WriteLine(" ----------- ");
            Console.WriteLine("  " + element + " | " + element + " | " + element + " \n");

        }
    }
}

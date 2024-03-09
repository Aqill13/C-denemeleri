using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Deneme
    {
        public static int row;
        public static int col;

        public static void yazdir()
        {
            Console.Write("Enter Row: ");
            row = int.Parse(Console.ReadLine());

            Console.Write("Enter Column: ");
            col = int.Parse(Console.ReadLine());
        }

        public static void arrDisplay()
        {
            int[,] arr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

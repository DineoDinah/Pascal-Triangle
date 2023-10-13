using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of row you wish to see on Pascal Triangle");
            int rows = int.Parse(Console.ReadLine());   
            int val = 1;
            int blank, i, j;
            Console.WriteLine("Pascal's triangle");
            for (i = 0; i<rows; i++)
            {
                for (blank = 1; blank <= rows-i; blank++)
                    Console.Write(" ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0||i == 0)
                        val = 1;
                    else
                        val = val*(i-j+1)/j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

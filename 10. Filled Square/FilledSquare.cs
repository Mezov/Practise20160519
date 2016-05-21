using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FilledSquare
    {    
    static void Main(string[] args)
        {
        
        int n = int.Parse(Console.ReadLine());

        printHeader(n);
        printMidle(n);
        printHeader(n);

        }
    static void printHeader(int n)
        {
        Console.WriteLine("{0}", new string('-', 2 * n));
        }
    static void printMidle(int n)
        {
        for (int a = 0; a < n - 2; a++)
            {
            Console.Write("-");
            for (int i = 0; i < n - 1; i++)
                {
                Console.Write(@"\/");
                }
            Console.Write("-");
            Console.WriteLine();
            }
        }
    }


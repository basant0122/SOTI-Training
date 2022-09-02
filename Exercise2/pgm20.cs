
/*
 20. Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk. 

   *
  * * 
 * * *
* * * *
 */

using System;


namespace Exercise2
{
    internal class pgm20
    {
        static void Main(string[] args)
        {
            Console.Write("Input number for pattern : ");
            int n = int.Parse(Console.ReadLine());
            int spc = n + 4 - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                spc--;
            }
            Console.ReadLine();
        }
    }
}

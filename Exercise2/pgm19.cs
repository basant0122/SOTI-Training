
///*
// 19. Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1. 

//   1 
//  2 3 
// 4 5 6 
//7 8 9 10
// */

//using System;


//namespace Exercise2
//{
//    internal class pgm19
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("input number for pattern : ");
//            int n = int.Parse(Console.ReadLine());
//           int spc = n + 4 - 1;
//            int t = 1;
//            for (int i = 1; i <= n; i++)
//            {
//                for (int k = spc; k >= 1; k--)
//                {
//                    Console.Write(" ");
//                }
//                for (int j = 1; j <= i; j++)
//                    Console.Write("{0} ", t++);
//                Console.Write("\n");
//                spc--;
//            }
//            Console.ReadLine();
//        }
//    }
//}

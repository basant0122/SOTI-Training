
///*
// 13. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
//Test Data :
//Input upto the table number starting from 1 : 8
//Expected Output :
//Multiplication table from 1 to 8
//1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
//...
//1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80
// */

//using System;


//namespace Exercise2
//{
//    internal class pgm13
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Input upto the table number starting from 1 : ");
//            int n = int.Parse(Console.ReadLine());
//            Console.Write("Multiplication table from 1 to {0} \n", n);
//            for (int i = 1; i <= 10; i++)
//            {
//                for (int j = 1; j <= n; j++)
//                {
//                    if (j <= n - 1)
//                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
//                    else
//                        Console.Write("{0}x{1} = {2}", j, i, i * j);

//                }
//                Console.Write("\n");
//            }
//            Console.ReadLine();
//        }
//    }
//}

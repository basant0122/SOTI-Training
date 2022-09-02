///*
// 14. Write a program in C# Sharp to display the n terms of odd natural number and their sum. 
//Test Data
//Input number of terms : 10
//Expected Output :
//The odd numbers are :1 3 5 7 9 11 13 15 17 19
//The Sum of odd Natural Number upto 10 terms : 100
// */

//using System;


//namespace Exercise2
//{
//    internal class pgm14
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Input number of terms : ");
//            int n = int.Parse(Console.ReadLine());
//            Console.Write("\nThe odd numbers are :");
//            int sum = 0;
//            for (int i = 1; i <= n; i++)
//            {
//                Console.Write("{0} ", 2 * i - 1);
//                sum += 2 * i - 1;
//            }
//            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
//            Console.ReadLine();
//        }
//    }
//}

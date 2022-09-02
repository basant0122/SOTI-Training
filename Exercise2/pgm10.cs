///*
// 10. Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: 
//Marks in Maths >=65
//Marks in Phy >=55
//Marks in Chem>=50
//Total in all three subject >=180
//or
//Total in Math and Subjects >=140

//Test Data :
//Input the marks obtained in Physics :65
//Input the marks obtained in Chemistry :51
//Input the marks obtained in Mathematics :72


//Expected Output :
//The candidate is eligible for admission.
// */

//using System;


//namespace Exercise2
//{
//    internal class pgm10
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Input the marks obtained in Physics :");
//            int p = int.Parse(Console.ReadLine());
//            Console.Write("Input the marks obtained in Chemistry :");
//            int c = int.Parse(Console.ReadLine());
//            Console.Write("Input the marks obtained in Mathematics :");
//            int m = int.Parse(Console.ReadLine());

//            if (m >= 65)
//                if (p >= 55)
//                    if (c >= 50)
//                        if ((m + p + c) >= 180 || (m + p) >= 140)
//                            Console.WriteLine("The  candidate is eligible for admission.");
//                        else if ((m + p + c) >= 180 || (m + c) >= 140)
//                            Console.WriteLine("The  candidate is eligible for admission.");
//                        else
//                            Console.WriteLine("The candidate is not eligible.");
//                    else
//                        Console.WriteLine("The candidate is not eligible.");
//                else
//                    Console.WriteLine("The candidate is not eligible.");
//            else
//                Console.WriteLine("The candidate is not eligible.");
//            Console.ReadLine();
//        }
//    }
//}

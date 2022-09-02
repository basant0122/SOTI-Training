
///*
//  Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies. 
//Test Data :
//Input the value for X coordinate :7
//Input the value for Y coordinate :9
//Expected Output :
//The coordinate point (7,9) lies in the First quadrant.
// */

//using System;


//namespace Exercise2
//{
//    internal class pgm9
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Input the value for X coordinate :");
//            int co1 = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Input the value for Y coordinate :");
//            int co2 = Convert.ToInt32(Console.ReadLine());


//            if (co1 > 0 && co2 > 0)
//                Console.WriteLine("The coordinate point ({0},{1}) lies in the First quandrant.", co1, co2);
//            else if (co1 < 0 && co2 > 0)
//                Console.WriteLine("The coordinate point ({0},{1}) lies in the Second quandrant.", co1, co2);
//            else if (co1 < 0 && co2 < 0)
//                Console.WriteLine("The coordinate point ({0},{1}) lies in the Third quandrant.", co1, co2);
//            else if (co1 > 0 && co2 < 0)
//                Console.WriteLine("The coordinate point ({0},{1}) lies in the Fourth quandrant.", co1, co2);
//            else if (co1 == 0 && co2 == 0)
//                Console.WriteLine("The coordinate point ({0},{1}) lies at the origin.", co1, co2);
//            Console.ReadLine();
//        }
//    }
//}

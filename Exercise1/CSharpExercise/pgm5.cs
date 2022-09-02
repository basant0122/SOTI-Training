
/*
 5. Write a C# Sharp program to swap two numbers. 
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5
 */

using System;


namespace CSharpExercise
{
    internal class pgm5
    {
        static void Main(string[] args)
        {
            Console.Write("enter 1st input : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("enter 2nd input : ");
            int n2 = int.Parse(Console.ReadLine());
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("After swap :");
            Console.Write("n1 = " + n1 + " " + "n2 = " + n2);

            Console.ReadLine();
        }
    }
}

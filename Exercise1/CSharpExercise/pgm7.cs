
/* 
7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
*/



using System;


namespace CSharpExercise
{
    internal class pgm7
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number : ");
            int nm1 = int.Parse(Console.ReadLine());
            Console.Write("Input the 2nd number : ");
            int nm2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum = " + (nm1 + nm2));
            Console.WriteLine("Subtraction = " + (nm1 - nm2));
            Console.WriteLine("Division = " + (nm1 / nm2));
            Console.WriteLine("Multiplication = " + (nm1 * nm2));
            Console.WriteLine("Modulus = " + (nm1 % nm2));
            Console.ReadLine();
        }
    }
}

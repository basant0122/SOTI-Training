
 
// 3.Write a C# Sharp program to print the result of dividing two numbers. 

using System;


namespace CSharpExercise
{
    class Div
    {
        public double div(int a, int b)
        {
            return (double)a / b;
        }
    }
    internal class pgm2
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Div dob = new Div();
            double divide = dob.div(num1, num2);
            Console.WriteLine("Division of two nos = " + divide);
            Console.ReadLine();
        }
    }
}

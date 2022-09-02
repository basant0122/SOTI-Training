

// 2. Write a C# Sharp program to print the sum of two numbers.



using System;


namespace CSharpExercise
{
    class Sum
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
    }
    internal class pgm2
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Sum sob = new Sum();
            Console.WriteLine("Sum of two nos = " + sob.sum(num1, num2));
            Console.ReadLine();
        }
    }
}

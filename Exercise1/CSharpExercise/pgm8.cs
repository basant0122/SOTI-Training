
/*8. Write a C# Sharp program that takes a number as input and print its multiplication table. 
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50
*/




using System;


namespace CSharpExercise
{
    internal class pgm8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Table of {0} is : ", num);
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(num * i);
            Console.ReadLine();
        }
    }
}


/* 
10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. 
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7

Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
*/

using System;


namespace CSharpExercise
{
    internal class pgm10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd number : ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter the 3rd number : ");
            int z = int.Parse(Console.ReadLine());
            int result1 = (x + y) * z;
            int result2 = x * y + y * z;
            Console.WriteLine("(x + y).z = {0}  x.y + y.z = {1}",result1,result2);
            Console.ReadLine();

        }
    }
}

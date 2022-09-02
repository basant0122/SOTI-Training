
/* 
6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. 
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
*/


using System;


namespace CSharpExercise
{

    internal class pgm6
    {
        static void Main()
        {
            Console.Write("Input the 1st number to multiply: ");
            int nm1 = int.Parse(Console.ReadLine());
            Console.Write("Input the 2nd number to multiply: ");
            int nm2 = int.Parse(Console.ReadLine());
            Console.Write("Input the 3rd number to multiply: ");
            int nm3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Result = " + (nm1 * nm2 * nm3));
            Console.ReadLine();

        }
    }
}

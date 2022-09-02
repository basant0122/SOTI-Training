
/* 
9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
*/



using System;

namespace CSharpExercise
{
    internal class pgm9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st number : ");
            int nm1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd number : ");
            int nm2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the 3rd number : ");
            int nm3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the 4th number : ");
            int nm4 = int.Parse(Console.ReadLine());
            int avg = (nm1 + nm2 + nm3 + nm4) / 4;
            Console.WriteLine("Average = {0}", avg);
            Console.ReadLine();
        }
    }
}

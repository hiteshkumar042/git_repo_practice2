using System.Diagnostics.CodeAnalysis;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taking 1st user input
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //taking 1st user input
            Console.Write("Enter the second number: ");
            int num2=Convert.ToInt32(Console.ReadLine());
            
            //addition
            int sum = num1 + num2;
            Console.WriteLine("Sum of {0} & {1} is: {2} ",num1,num2,sum);
            
            //subtraction
            int subt = num1 - num2;
            Console.WriteLine("Subtraction of {0} & {1} is: {2} ", num1, num2, subt);
            
            //multiplication
            int mul = num1 * num2;
            Console.WriteLine("Multiplication of {0} & {1} is: {2} ", num1, num2, mul);
            
            //division
            float div = num1 / num2;
            Console.WriteLine("Division of {0} & {1} is: {2} ", num1, num2,div);

            //remainder
            int rem = num1 % num2;
            Console.WriteLine("Remainder of {0} & {1} is: {2} ", num1, num2, rem);      }

    }
}
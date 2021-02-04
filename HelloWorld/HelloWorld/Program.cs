using System;
namespace HelloWorld
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Input your first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The max number of the 2 numbers is: ");
            Console.WriteLine(Math.Max(num1, num2));


        }

    }
    }


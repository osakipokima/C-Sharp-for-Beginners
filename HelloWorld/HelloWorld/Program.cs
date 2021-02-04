using System;
namespace HelloWorld
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var userInput = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = userInput; i != 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("The factorial of " + userInput + " is " + factorial);


        }
    }
}




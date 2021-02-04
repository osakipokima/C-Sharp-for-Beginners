using System;
namespace HelloWorld
{
    class program
    {

        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or type ok to Exit: ");
                var userInput = Console.ReadLine();

                if(userInput.ToLower() == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(userInput);

            }
            Console.WriteLine("The sum of the numbers entered is " + sum);









        }

    }
}


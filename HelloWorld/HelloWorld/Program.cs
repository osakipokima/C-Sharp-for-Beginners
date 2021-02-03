using System;
namespace HelloWorld
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1-10: ");        
            int userInput = Convert.ToInt32(Console.ReadLine());

            if(userInput >= 1 && userInput <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            

        }

        }
    }


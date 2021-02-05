using System;

namespace HelloWorld
{
    class program
    {



        static void Main(string[] args)
        {
            var randomNumber = new Random().Next(1, 10);
            Console.WriteLine("Secret is " + randomNumber);

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Guess a number between 1 - 10: ");
                var userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == randomNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }
               
            }
            Console.WriteLine("You lost");




        }
    }
}




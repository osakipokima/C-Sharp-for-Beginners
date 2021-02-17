using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            //declaring variables for guess game
            string secertWord = "doge";
            string guess = "";
            int guestCount = 0;
            int guestLimit = 3;
            bool outOfGuesses = false;
            //User has a max of 3 guesses to guess the word otherwise they lose
            do
            {
                // incrementing guest count based on user's answer
                if (guestCount < guestLimit)
                {
                    Console.WriteLine("Enter a guess: ");
                    guess = Console.ReadLine();
                    guestCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
                // looping until the user has run out of guesses and hasn't guessed the word
            } while (guess != secertWord && !outOfGuesses);
            
            //print whenther the user has won or lost
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");

            }
            else
            {
                Console.WriteLine("You Win!");

            }
            Console.ReadLine();



        }





    }
}





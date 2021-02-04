using System;
namespace HelloWorld
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the image");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of the image");
            int height = Convert.ToInt32(Console.ReadLine());

            if(height > width)
            {
                Console.WriteLine("This is a portrait image.");
            }
            else
            {
                Console.WriteLine("This is a landscape image.");
            }






        }

    }
    }


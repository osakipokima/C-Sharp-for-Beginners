using System;
namespace HelloWorld
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Speed Limit:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How fast are you driving?");
            int carSpeed = Convert.ToInt32(Console.ReadLine());


            int dermitPoints = (carSpeed - speedLimit) / 5;

            if(carSpeed > speedLimit && dermitPoints <= 12)
            {
                Console.WriteLine("Dermit Points: " + dermitPoints);
            }
            else if(dermitPoints > 12){
                Console.WriteLine("License Suspended");

            }
            else
            {
                Console.WriteLine("Keep driving safely");
            }


















        }

    }
    }


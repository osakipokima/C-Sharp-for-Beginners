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
            //first number from user
            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //type of computation
            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            //second number from user
            Console.Write("Enter a Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //adding
            if (op == "+")
            {
                Console.Write(num1 + num2);

            } //subtracting 
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            //dividing
            else if (op == "/") 
            {
                Console.WriteLine(num1 / num2);

            } // multiplying 
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }





        }

           



        
    }
}





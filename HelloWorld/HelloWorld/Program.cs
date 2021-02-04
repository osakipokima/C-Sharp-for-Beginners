using System;
namespace HelloWorld
{
    class program
    {

        static void Main(string[] args)
        {
            var counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter += 1;

                }

            }
            Console.WriteLine(counter);


        }

    }
}


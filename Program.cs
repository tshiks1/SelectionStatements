using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 89;
            var userInput = int.Parse(Console.ReadLine());


            if (userInput !< favNumber)
            {
                Console.WriteLine("Too low");
            }

            else if (userInput == favNumber)
            {
                Console.WriteLine("You are Right");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            //Create an if-statement that if the guessed number is below the initial value, print out “too low”.
           // Create an else -if statement that if the number is higher than the initial value, print out “too high”.
//Create an else statement that prints out “Nevermind”.





           
        }
    }
}

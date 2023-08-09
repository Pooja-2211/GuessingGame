using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GuessingGame
{
    static void Main()
    {
        Random ranNumberGenerator = new Random();
        int min = 1;
        int max = 11;
        int randomNumber = ranNumberGenerator.Next(min, max);

        Console.Write("Guess the number (between 1 and 10): ");
        int userGuess = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The random number is: " + randomNumber);

        if (userGuess < randomNumber)
        {
            Console.WriteLine("Too low");
        }
        else if (userGuess > randomNumber)
        {
            Console.WriteLine("Too high");
        }
        else
        {
            Console.WriteLine("Correct");
        }
    }
}


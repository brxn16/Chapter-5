using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            int againLower = 1;
            int againHigher = 10;
            int count = 1;
            string guessString;
            int guess = 9000;
            string result = null;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            while(guess != randomNumber)
            { 
            WriteLine("Choose a number between 1-10");
            guessString = ReadLine();
            guess = Convert.ToInt32(guessString);

            if (guess <= 10 && guess >= 1)
            {
                if (randomNumber == guess)
                {
                    result = "Congratulations on the guess of " + randomNumber;
                }
                else if (guess < randomNumber)
                {
                    result = "You guessed " + guess + ". Too low.";
                    if (guess <= againLower)
                    {
                        result = "What?! " + guess + "? Why? SMH";
                    }
                    againLower = guess;
                }
            }
            else if (guess > randomNumber)
            {
                result = "You guessed " + guess + ". Too high.";
                if (guess >= againHigher)
                {
                    result = "What?! " + guess + "? Why? SMH";
                }
                againHigher = guess;
            }
            else if (guess < min || guess >= max)
            {
                result = "Out of Bounds";
            }
            DisplayString(result);
            count++;
            }
            result = "You guessed " + guess + " in " + count + " tries.";
            DisplayString(result);
        }
       
        static void DisplayString(string result)
        {
            WriteLine(result);
        }
    }
   
}

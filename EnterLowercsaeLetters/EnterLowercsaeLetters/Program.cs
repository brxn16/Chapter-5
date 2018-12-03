using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EnterLowercsaeLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            string letterString;

            WriteLine("Please enter a lowercsae number.");
            letterString = ReadLine();
            letter = Convert.ToChar(letterString);

            if(letter >= 'a' && letter <= 'z')
            {
                WriteLine("OK");
            }
            else
            {
                WriteLine("Please make it a lowercase letter bozo!");
            }
        }
    }
}

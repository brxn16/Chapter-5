using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 0;
            const int MAX = 100;
            const int MIN = 0;
            string testString;
            int average = 0;
            int total = 0;
            int count = 0;
            int Invalid = 0;

            while (test != 999)
            { 
                WriteLine("Please enter your test scores. Type 999 to show your average score.");
                testString = ReadLine();
                test = Convert.ToInt32(testString);
                if (test < MAX && test > MIN)
                {
                    total = test + total;
                    count++;
                }
                else if(test == 999)
                {
                    WriteLine("Invalid Score.");
                    Invalid++;
                    average = total / count;
                    WriteLine("The average is " + average);
                }
              
            }
           

        }
    }
}

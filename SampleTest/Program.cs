using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //build a calculator 

            //Console.WriteLine("Enter Number one");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number two");
            //int numberTwo = int.Parse(Console.ReadLine());
            //int answer = numberOne + numberTwo;            
            //Console.WriteLine("The answer is {0} + {1} = {2}", numberOne, numberTwo, answer);
            //Console.ReadLine();

            //total amount of time in minutes only

            Console.WriteLine("Enter the time in minutes only");
            int toalMints = int.Parse(Console.ReadLine());
            int mintsHours = toalMints / 60;
            int leftMins = toalMints % 60;
            Console.WriteLine("Total amount of time is {0} minutes and {1} hour and {2} minutes", toalMints,mintsHours,leftMins );
            Console.ReadLine();

        }
    }
}

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
            //1. build a calculator 

            //Console.WriteLine("Enter Number one");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number two");
            //int numberTwo = int.Parse(Console.ReadLine());
            //int answer = numberOne + numberTwo;
            //Console.WriteLine("The answer is {0} + {1} = {2}", numberOne, numberTwo, answer);
            //Console.ReadLine();

            ////2. total amount of time in minutes only

            //Console.WriteLine("Enter the time in minutes only");
            //int toalMints = int.Parse(Console.ReadLine());
            //int mintsHours = toalMints / 60;
            //int leftMins = toalMints % 60;
            //Console.WriteLine("Total amount of time is {0} minutes which is {1} hour and {2} minutes", toalMints,mintsHours,leftMins );
            //Console.ReadLine();

            //3. Compund expression in If-else statement

            //Console.WriteLine("Enter hourly rate");
            //double rate = double.Parse(Console.ReadLine());
            //if(rate < 7.00 || rate > 49.00)
            //{
            //    Console.WriteLine("Invalid rate");
            //}
            //else
            //{
            //    Console.WriteLine("Valid rate");
            //}
            //Console.ReadLine();

            //4. Switch Statements 

            Console.WriteLine("Enter the length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width");
            int width = int.Parse(Console.ReadLine());
            int squreRoot = length * width;
            int totalFee = squreRoot * 20;

            if (400 > squreRoot)
            {
                Console.WriteLine("The weekly mowing fee is $25");
            }
            else if (400 <= squreRoot || 600 > squreRoot)
            {
                Console.WriteLine("The weekly mowing fee is $35");
         
            }
            else if (600 <= squreRoot)
            {
                Console.WriteLine("The weekly mowing fee is $35");
            }

            Console.WriteLine("The total fee is:" + totalFee);
            Console.ReadLine();

        }
    }
}

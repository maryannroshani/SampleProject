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

            Console.WriteLine("Enter Number one");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number two");
            int numberTwo = int.Parse(Console.ReadLine());
            int answer = numberOne + numberTwo;
            Console.WriteLine("The answer is {0} + {1} = {2}", numberOne, numberTwo, answer);
            Console.ReadLine();

            //2. total amount of time in minutes only

            Console.WriteLine("Enter the time in minutes only");
            int toalMints = int.Parse(Console.ReadLine());
            int mintsHours = toalMints / 60;
            int leftMins = toalMints % 60;
            Console.WriteLine("Total amount of time is {0} minutes which is {1} hour and {2} minutes", toalMints, mintsHours, leftMins);
            Console.ReadLine();

           // 3.Compund expression in If -else statement

            Console.WriteLine("Enter hourly rate");
            double rate = double.Parse(Console.ReadLine());
            if (rate < 7.00 || rate > 49.00)
            {
                Console.WriteLine("Invalid rate");
            }
            else
            {
                Console.WriteLine("Valid rate");
            }
            Console.ReadLine();

           // 4.Switch Statements

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

            //5. Generate a random number 

            Random randomGenerator = new Random();
            int randomNo = randomGenerator.Next(1, 11);

            Console.WriteLine("Guess a random No");            
            int guessNo = int.Parse(Console.ReadLine());

            if (guessNo < randomNo )
            {
                Console.WriteLine("Guess number is too high  the random no is " + randomNo);
            }

            else if (guessNo > randomNo)
            {
                Console.WriteLine("Guess number is too low, the random no is " + randomNo);
            }
            else
            {
                Console.WriteLine("The random no is correct");
            }

            Console.ReadLine(); 

            // 6. While loop


            int runningTotal = 0;
            Console.WriteLine("Enter no to continue or enter -1 to quit");
            int number = int.Parse(Console.ReadLine());
          
           while (number !=  -1 )
            {
                
                Console.WriteLine(runningTotal += number);
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(runningTotal); 

            //7. For loop

            Console.WriteLine("Enter amount of time you want to print Hello");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Hello Maryann");
                
            }
            Console.ReadLine(); 


            //8. Nested loop 


            int size = 15;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write("{0, -5 }", "*&%^");
                }

                Console.WriteLine();

            }
            Console.ReadLine();


            //9. Loop - Excercise

            double rate;

            do {
                Console.WriteLine("Enter a valid hourly rate");
                 rate = double.Parse(Console.ReadLine());
            }
            while (rate < 5.65 || rate > 49.99) ;
            Console.WriteLine("The valid pay rate is {0}", rate);
            Console.ReadLine(); 


            //10. Loop - Excercise

            int runningTota = 0;

            for (int i = 1; i < 50; i++)
            {
               runningTotal +=i;
            }
            Console.WriteLine("Sum is {0}", runningTota);
            Console.ReadLine();
        }
    }
}


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

            Console.WriteLine("Enter Number one");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number two");
            int numberTwo = int.Parse(Console.ReadLine());
            int answer = numberOne + numberTwo;  
           
            Console.WriteLine("The answer is {0} + {1} = {2}", numberOne, numberTwo, answer);
            Console.ReadLine();
        }
    }
}

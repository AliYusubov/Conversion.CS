using System;
using System.Diagnostics.Metrics;

namespace ALi
{
    class NumberManipulator
    {

        static void Main(string[] args){

            short a;
            int b;
            double c;
            double d;

            /* actual initialization */
            a = 96;
            b = 85;
            c = 72;
            d = 98;
            Console.WriteLine(@"
Enter the score for subject 1: {0}
Enter the score for subject 2: {1}
Enter the score for subject 3: {2}
The Average grade is: {3}", a , b, c, d);

            Console.ReadLine();

            
        }

        
    }
}
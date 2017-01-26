using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testbig0
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int[] makeAnArray = new int[userNumber];
            for (var x = 0; x < userNumber; x++)
            {
                makeAnArray[x] = x; 
            }
            DisplayIterations(makeAnArray);
        }
        static void DisplayIterations(int[] testA)
        {
            int totalIterations = 0;
            for (var i = 0; i < testA.Length; i++)
            {
                totalIterations++;
                Console.WriteLine("i is " + i );
                for (var j = i + 1; j < testA.Length; j++)
                {
                    totalIterations++;
                    Console.WriteLine("j is " + j);
                }
            }
            Console.WriteLine("The amount of iterations: " + totalIterations);
        }
    }
}

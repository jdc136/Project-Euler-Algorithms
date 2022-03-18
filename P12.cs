using System;
using System.Collections.Generic;

namespace P1 {
    class Program {

        // First, I need to know which numbers are the triangle numbers!
        // Second, I need to know the factors, and the # of factors, for each triangle number

        public static int GetPyramidNum(int limit) 
        {
            int pyramidNum = 0;
            for (int i = 1; i <= limit; i++) 
            {
                pyramidNum += i;
            }
            return pyramidNum;
        }

        public static int GetNumOfFactors(int num) {
            // Credit goes to: https://codereview.stackexchange.com/questions/237416/c-code-to-find-all-divisors-of-an-integer
            List<int> divisors = new List<int>();
            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    divisors.Add(i);
                    if (i != num / i)
                    {
                        divisors.Add(num / i);
                    }
                }
            }
            return divisors.Count;
        }

        public static void Main(string[] args) {
            int limitOfDivisors = 500;
            int numOfDivisors = 0;
            int pyramidNum = 0;
            int counter = 0;

            while (numOfDivisors < limitOfDivisors) 
            {
                counter++;
                pyramidNum = GetPyramidNum(counter);
                numOfDivisors = GetNumOfFactors(pyramidNum);
                //Console.WriteLine($"Counter: {counter}, Pyramid #: {pyramidNum}, Num of Divisors: {numOfDivisors}");                
            }
            Console.WriteLine($"The first triangular number to have over five hundred divisors is: {pyramidNum:n0}.");
        }
    }
}

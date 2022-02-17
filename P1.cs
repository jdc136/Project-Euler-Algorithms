// Problem: Find the sum of all the multiples of 3 or 5 below 1000
using System;

namespace P1 {
    class Program {

        static void Main(string[] args) {
            int sum = 0;
            int limit = 1000;

            for (int i = 1; i < limit; i++) {
                if (i % 3 == 0 || i % 5 == 0)
                    sum = sum + i;
            }

            Console.WriteLine("The sum of numbers divisible by 3 and 5 between 1 and {0} equals: {1}", (limit - 1), sum);

        }
    }
}

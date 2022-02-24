// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17. Find the sum of all the primes below two million.
using System;

namespace P1 {
    class Program {

        public static bool IsPrime(int n) {
            // credit: https://en.wikipedia.org/wiki/Primality_test#C#,_C++_&_C
            if (n == 2 || n == 3)
                return true;
            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;
            for (int i = 5; i * i <= n; i += 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            return true;
        }

        public static void Main(string[] args) {

            int counter = 2;
            int limit = 2_000_000;
            long sum = 0;

            while (counter < limit) {
                if (IsPrime(counter)) {
                    sum = sum + counter;
                }
                counter++;
            }
            Console.WriteLine($"The sum of all primes below {limit:n0} is {sum:n0}");
        }
    }
}

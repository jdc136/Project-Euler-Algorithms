//What is the 10 001st prime number?
using System;

namespace P1 {
    class Program {

        // Considerations/steps
        // Primes! 
        // Step 1: I believe we will have to first determine if a given number is a prime
        // Step 2: once a number is determined to be a prime, we can then say it is the Xth prime
        // How will we do this? Yet TBD. One idea is a multi-dimensional array/List with one element being the prime number itself and the other being the # of the prime in relation to all primes
        // Step 3: Step 2 will be embedded in a loop that stops once we reach 10,001
        // The crucial piece is: do I need to add these into some kind of data structure? Or can I simply hold the "place" in a variable. I think the latter

        // Here, I am referring to an algorithm to determine if a number is prime from a book called "Algorithms" by Sedgewick and Wayne, pp. 23 (saw this from project three)
        public static bool IsPrime(long n) {
            if (n < 2) return false;
            for (long i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        
        public static void Main(string[] args) {

            int limit = 10_001; // the 10,001st prime number is what we want
            int count = 1; // the first, second, third, etc. prime number
            long candidate = 1; // the number that is the prime number      

            while (count < limit) {
                //Console.WriteLine("Count: {0}, Candidate: {1}", count, candidate);
                candidate = candidate + 2;
                if (IsPrime(candidate))
                    count = count + 1;
            }

            Console.WriteLine("The {0:n0} prime is {1:n0}", count, candidate);
        }
    }
}

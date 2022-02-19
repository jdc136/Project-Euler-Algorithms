// Problem: What is the largest prime factor of the number 600851475143?
// Credit goes to user khouloudzaiter at https://dev.to/peter/project-euler-3---largest-prime-factor-1icf
using System;

namespace P3 {
    class Program {    
        public static void Main(string[] args) {

            long limit = 600_851_475_143;
            long n = limit;
            long largestPrimeFactor = limit;

            long i = 2;
            while (i <= n && n != 1) {
                if (n % i == 0) {
                    n = n / i;
                    largestPrimeFactor = i;
                } else {
                    i = i + 1;
                }
            }

            Console.WriteLine($"The largest prime factor of the number {limit:n0} is {largestPrimeFactor:n0}");

        }
    }
}

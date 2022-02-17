// Problem: By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
using System;

namespace P2 {
    class Program {

        static void Main(string[] args) {
            int A = 0;
            int B = 1;
            int C = 0;
            int limit = 4_000_000;
            int sum = 0;

            while (B < limit) {
                if (B % 2 == 0)
                    sum = sum + B;
                //Console.WriteLine("A: {0}, B: {1}, C: {2}", A, B, C);
                C = A + B;
                A = B;
                B = C;
            }
            Console.WriteLine("The sum of the even-valued terms whose values do not exceed {0:n0} is {1:n0}.", limit, sum);
        }
    }
}

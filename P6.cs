// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
using System;

namespace P1 {
    class Program {
        public static void Main(string[] args) {
            // Considerations
            // This seems pretty easy: simply add up the sum of the squares with a loop, and separately the square of the sum, and then take the difference in appropriate order
            // The problem comes down to composition - what operations are being performed on what, and in which order?

            int limit = 100;
            int sumOfSquares = 0;
            int squareOfSum = 0;

            // first get the sum of the squares
            for (int i = 1; i <= limit; i++) {
                sumOfSquares = sumOfSquares + (i * i);
            }

            for (int i = 1; i <= limit; i++) {
                squareOfSum = squareOfSum + i;
            }

            squareOfSum = squareOfSum * squareOfSum;

            int differenceOfSquares = squareOfSum - sumOfSquares;

            Console.WriteLine("The difference between sum of squares of the first one hundred natural numbers and the square of the sum is: {0:n0} - {1:n0} = {2:n0}", squareOfSum, sumOfSquares, differenceOfSquares);
        
        }
    }
}

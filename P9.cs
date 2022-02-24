//There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.
using System;

namespace P1 {
    class Program {

        // Considerations
        // I made many considerations for this one, so I've written them down in the README file for this problem

        public static int[] PythagoreanTriplet(int lim) {
            int[] numbers = new int[3];
            int limit = lim;

            for (int i = 1; i < limit - 1; i++) {
                for (int j = i + 1; j < limit; j++) {
                    for (int k = j + 1; k <= limit; k++) {
                        //Console.WriteLine("A: {0}, B: {1}, C: {2}", i, j, k);
                        if ((((i * i) + (j * j)) == (k * k)) && ((i + j + k) == 1000)) {
                            numbers[0] = i;
                            numbers[1] = j;
                            numbers[2] = k;
                            return numbers;
                        }
                    }
                }
            }
            return numbers;
        }

        public static void Main(string[] args) {
            int[] answers = PythagoreanTriplet(998);

            int a = answers[0];
            int b = answers[1];
            int c = answers[2];
            long answer = a * b * c;

            Console.WriteLine($"The one Pythagorean triplet for which a + b + c = 1000 is {a} + {b} + {c}.\n" +
                $"The product of abc is: {answer:n0}");
        }
    }
}

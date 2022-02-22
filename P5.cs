// Problem: Find the largest palindrome made from the product of two 3-digti numbers
using System;

namespace P1 {
    class Program {

        // Considerations
        // Consideration 1: A number that will be evenly divisible by all numbers from 1-20 will be an even number because an even # can only have 0 remainder from an even #
            // --> we can use this fact to help it go a bit faster
        // Consideration 2: Since 20 is one of the numbers, it must at least be 20, however, it can't be 20 itself because 20 % (20 - 2) = 2 (I think some factor of all the even numbers from 1-20)
        // Consideration 3: Check what the remainder for every # 1-20... you could have an && statement with the % for each one... but you could also do a loop
        
        // Algorithm
        // 1. set up a counter variable equal to 20
        // 2. check if 20 has a non-zero remainder from every # 1-20.
            // 2a. The first 20 % (1-20) that has a non-zero remainder, return false
            // 2b. If and only if all remainders are zero, return true
        // 3. If 2a then add two to your variable. If 2b, then exit the loop

        public static bool NoRemainder(int n) {
            for (int i = 1; i < 21; i++)
                //Console.WriteLine("\tThe number {0} % {1} equals {2}", n, i, (n % i));
                //Console.ReadKey();
                if (n % i != 0)
                    return false;
            return true;
        }

        public static void Main(string[] args) {
            int counter = 20; // set to start at 20          
            while (!NoRemainder(counter) /*true*/) {
                //Console.WriteLine("The number {0} is: {1}", counter, NoRemainder(counter));                
                counter = counter + 2;
            }
            Console.WriteLine("The smallest number that can be divided by each of the numbers from 1 to 10 without any remainder is {0:n0}", counter);
        }
    }
}

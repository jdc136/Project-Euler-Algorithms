// Problem: Find the largest palindrome made from the product of two 3-digit numbers

using System;

namespace P1 {
    class Program {

        // algorithm & considerations
        // consideration 1: we need TWO 3-digit numbers. A 3-digit number can be anything from 100-999
        // consideration 2: as the product of TWO 3-digit numbers increases as each argument increases, our range is: 100x100 = 10,000 or 999*999 = 998,001
        // i.e. 10,000 to 998,001
        // consideration 3: the TWO 3-digit numbers may NOT be equal, such as 100*999 = 99,900 or 638*249 = 158,862
        // the range of numbers between 100 and 999 = 999 - 100 = 899 3-digit numbers. If we try multiply 899 different numbers by all the other 899 numbers, that is a LOT of different combinations (899! I think, but I'm no math major)
        // consideration 4: given (3), it seems like it would be better to loop through all the numbers from 10,000 to 998,001, going from largest down, to get the first palindromic number
        // consideration 5: if we go with (4), then we can check whether each number is a palindrome.        
        // consideration 6: however, we also need to check that the number is a product of TWO 3-digit numbers

        public static bool CheckMultiple(int number) {
            // credit: https://stackoverflow.com/questions/46874363/find-numbers-which-are-a-product-of-two-3-digit-numbers-project-euler-4
            int num = number;
            for (int i = 100; i < 1000; i++) {
                for (int j = 100; j < 1000; j++) {
                    if ((i * j) == num) {
                        return true;
                    }
                }
            }
            return false;
        }
        
        public static bool IsPalindrome(int number) {
            // credit: https://www.c-sharpcorner.com/blogs/program-to-check-the-number-is-palindrome-or-not2
            int num = number;
            int rem;
            int sum = 0;
            int temp = num;
            while (num > 0) {
                rem = num % 10; // for getting remainder by dividing with 10
                num = num / 10; // for getting quotient by dividing with 10
                sum = sum * 10 + rem; // multiplyng the sum with 10 and adding remainder
            }
            if (temp == sum) {
                return true;
            } else {
                return false;
            }
        }

        public static void Main(string[] args) {
            int upperLimit = 998_001;
            int lowerLimit = 10_000;
            while (upperLimit >= lowerLimit) {
                if (IsPalindrome(upperLimit) && CheckMultiple(upperLimit)) {
                    break;
                } else {
                    upperLimit--;
                }               
            }
            Console.WriteLine("The largest palindromic number made from the product of two 3-digit numbers is {0}", upperLimit);
        }
    }
}

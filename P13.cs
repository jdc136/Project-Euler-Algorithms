using System;
using System.IO;
using System.Numerics;

namespace P1 {

    class Program 
    {
        public static BigInteger[] ParseLargeNumbers(string[] strLargeNumbers)
        {
            BigInteger[] largeNumbers = new BigInteger[strLargeNumbers.Length];
            for (int i = 0; i < strLargeNumbers.Length; i++)
            {
                BigInteger.TryParse(strLargeNumbers[i], out largeNumbers[i]);
            }
            return largeNumbers;
        }

        public static BigInteger GetMassiveNumber(BigInteger[] largeNumbers)
        {
            BigInteger sum = 0;

            foreach (var number in largeNumbers)
            {
                sum += number;
            }

            return sum;
        }

        public static void Main(string[] args) 
        {
            string fileName = "Problem13.txt";
            string[] strLargeNumbers = System.IO.File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"Files\", fileName));
            BigInteger[] largeNumbers = ParseLargeNumbers(strLargeNumbers);
            BigInteger massiveNumber = GetMassiveNumber(largeNumbers);

            Console.WriteLine("The first ten digits of the sum of one-hundred 50-digit numbers (from file) is: {0}", massiveNumber.ToString().Substring(0, 10));
        }
    }
}

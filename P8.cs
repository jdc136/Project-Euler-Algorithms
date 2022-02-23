//Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
using System;

namespace P1 {
    class Program {

        // Considerations
        // Consideration 1: can this number be held as a numeric type? I don't think so... if not, it will have to be held as an array, with each digit being a separate element in the array
        // Consideration 2: once I get that first part figured out, then to get the 13 sequential digits with the highest product, I will need to:
        // a) starting from index 0 multiply those 13 digits (0-12), then set that value equal to a variable (let's call it "product")
        // b) the second loop will go through from indices 1-13, and IF the product of those is higher than the previous one, we'll assign it to "product"
        // c) we'll keep going through until we get to the end 13 digits, (999 - 13) - 999
        // Consideration 3: there will be two loops
        // Loop A will add 1 to the index each time
        // Loop B will go through 13 digits after the current index and multiply each of those

        // going back to needing to put the number into an array... it looks like there's no way that can be stored as a numeric, so indeed it will have to go into an array
        // We can declare it as a string, then:
        // 1 - declare an array with a length the same as the string

        public static int length; // change how many numbers in a row you'd like to multiply

        public static string hugeNum = "73167176531330624919225119674426574742355349194934"
            + "96983520312774506326239578318016984801869478851843"
            + "85861560789112949495459501737958331952853208805511"
            + "12540698747158523863050715693290963295227443043557"
            + "66896648950445244523161731856403098711121722383113"
            + "62229893423380308135336276614282806444486645238749"
            + "30358907296290491560440772390713810515859307960866"
            + "70172427121883998797908792274921901699720888093776"
            + "65727333001053367881220235421809751254540594752243"
            + "52584907711670556013604839586446706324415722155397"
            + "53697817977846174064955149290862569321978468622482"
            + "83972241375657056057490261407972968652414535100474"
            + "82166370484403199890008895243450658541227588666881"
            + "16427171479924442928230863465674813919123162824586"
            + "17866458359124566529476545682848912883142607690042"
            + "24219022671055626321111109370544217506941658960408"
            + "07198403850962455444362981230987879927244284909188"
            + "84580156166097919133875499200524063689912560717606"
            + "05886116467109405077541002256983155200055935729725"
            + "71636269561882670428252483600823257530420752963450";        

        public static char[] PopulateCharArray(string value) {            
            char[] hugeNumArray = new char[hugeNum.Length];
            for (int i = 0; i < hugeNum.Length; i++) {
                hugeNumArray[i] = hugeNum[i];
                //Console.WriteLine(hugeNumArray[i]);
            }
            return hugeNumArray;
        }

        public static long GetLargestProduct(char[] charArray) {
            int counter = 0; // keeps track of where we are in the array
            long product = 1; // the product of the sequential digits
            long highProduct = 0;

            while (counter < charArray.Length - length + 1) {
                
                for (int i = counter; i < counter + length; i++)
                    product = product * int.Parse(charArray[i].ToString());
                
                if (product > highProduct)
                    highProduct = product;
                
                product = 1; // reset to 1
                counter++;
            }
            return highProduct;
        }

        public static void Main(string[] args) {
            Console.Write("Please enter a number: ");
            length = Convert.ToInt32(Console.ReadLine());
            char[] digitArray = PopulateCharArray(hugeNum);
            Console.WriteLine("The product of {0} adjacent digits with the greatest value in this 1000-digit number \n\t{1}\n is: {2:n0}", length, hugeNum, GetLargestProduct(digitArray));            
        }
    }
}

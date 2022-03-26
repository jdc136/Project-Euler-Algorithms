using System;

namespace P1 {

    class Program 
    {
        
        public static int GetCollatzSequenceLength(long num)
        {
            int count = 1;
            while (num > 1) // won't work for 1 itself, when 1 is the starting number
            {                
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = (3 * num) + 1;
                }
                count++;
            }
            return count;
        }

        public static int GetLongestCollatzSequence(int limit)
        {
            int longestSequence = 0;
            int startNumber = 0;

            for (int i = 2; i <= limit; i++)
            {                
                int sequenceLength = GetCollatzSequenceLength(i);
                if (sequenceLength > longestSequence)
                {
                    longestSequence = sequenceLength;
                    startNumber = i;
                }
            }
            return startNumber;
        }

        public static void Main(string[] args) 
        {
            int limit = 1000000;

            Console.WriteLine("{0:n0}", GetLongestCollatzSequence(limit));          
        }
    }
}

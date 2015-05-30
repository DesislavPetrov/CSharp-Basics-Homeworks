
using System;


    class AdvancedBitsExchange
    {
        public static void Main()
        {
            uint num = uint.Parse(Console.ReadLine()); // enter the number

            int p = int.Parse(Console.ReadLine()); // enter the "p" bit
            int q = int.Parse(Console.ReadLine()); // enter the "p" bit
            int k = int.Parse(Console.ReadLine()); // enter the increased "k" bit

            if ((Math.Abs(p - q)) < k) // check for overlapping
            {
                Console.WriteLine("overlapping"); 
            }
            else if (((p + k - 1) > 31 || (q + k - 1) > 31) || (p < 0 || q < 0)) // check for out of range
            {
                Console.WriteLine("out of range");
            }
            else
            {
                if (p > q)
                {
                    int tempValue = p;
                    p = q;
                    q = tempValue;
                }
                for (int i = p; i < p + k; i++)
                {
                    uint firstGroup = (uint)(num >> i) & 1; // check the value of the bit from the first group at this position
                    uint secondGroup = (uint)(num >> q) & 1; // check the value of the bit from the first group at this position

                    if (firstGroup != secondGroup) // check if the bits values from the two groups are different
                    {
                        uint firstMask = (uint)(1 << i);
                        uint secondMask = (uint)(1 << q);

                        num = (uint)num ^ firstMask;
                        num = (uint)num ^ secondMask;
                    }
                    q++; // increase "q" value
                }
                Console.WriteLine(num);
            }
        }
    }

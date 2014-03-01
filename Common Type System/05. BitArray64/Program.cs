namespace BitArray64
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            BitArray64 test = new BitArray64((ulong)127);

            Console.WriteLine(test.AllBits());
            Console.WriteLine(test.AllBits().Length);

            foreach (var bit in test)
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            BitArray64 test2 = new BitArray64((ulong)129);

            Console.WriteLine(test == test2);
            Console.WriteLine(test.GetHashCode());
            Console.WriteLine(test2.GetHashCode());

            Console.WriteLine(test[1]);
        }
    }
}

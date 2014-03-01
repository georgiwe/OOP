namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private const int NumOfBits = 64;
        private ulong num;

        public BitArray64(ulong num)
        {
            this.num = num;
        }

        public int this[int ind]
        {
            get
            {
                var bit = ((ulong)1 << ind) & this.num;

                if (bit == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 other)
        {
            return first.Equals(other);
        }

        public static bool operator !=(BitArray64 first, BitArray64 other)
        {
            return first.Equals(other);
        }

        public string AllBits()
        {
            var result = new StringBuilder();

            for (int i = 0; i < NumOfBits; i++)
            {
                var bit = ((ulong)1 << i) & this.num;

                if (bit == 0)
                {
                    result.Append(0);
                }
                else
                {
                    result.Append(1);
                }
            }

            var res = result.ToString().ToCharArray();
            Array.Reverse(res);

            return new string(res);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("The object you are comparing to is null");
            }

            var other = obj as BitArray64;

            var firstBits = this.AllBits();
            var otherBits = other.AllBits();

            return firstBits == otherBits;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < NumOfBits; i++)
            {
                var bit = ((ulong)1 << (NumOfBits - i - 1)) & this.num;

                if (bit == 0)
                {
                    yield return 0;
                }
                else
                {
                    yield return 1;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            var bits = this.AllBits();

            int result = 0;

            foreach (var bit in bits)
            {
                result += bit ^ 4;
            }

            return result * 33;
        }
    }
}
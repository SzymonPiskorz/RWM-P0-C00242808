using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class XORFilterTest
    {
        [Test]
        public void XORFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = XORFilter.XOR21s(input);
            int[] expected = { 17, 23, 29, 22, 28, 17, 31 };

            CollectionAssert.AreEqual(expected, output);

            int[] input1 = { 1, 0, 8, 3, 9, 4, 10 };
            int[] output1 = XORFilter.XOR21s(input1);
            int[] expected1 = { 20, 21, 29, 22, 28, 17, 31 };

            CollectionAssert.AreEqual(expected1, output1);
        }
    }
}

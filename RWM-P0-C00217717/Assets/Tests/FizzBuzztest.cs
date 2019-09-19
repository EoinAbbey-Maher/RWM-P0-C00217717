using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class FizzBuzztest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void FizzBuzztestSimple()
        {
            int[] input = {4,3,6,30,10,12 };
            int[] output = FizzBuzzFilter.multiFizzBuzz(input);
            int[] expected = { 4, 3, 3, 0, 5, 3 };
            // Use the Assert class to test conditions

            CollectionAssert.AreEqual(expected, output);
        }

    }
}

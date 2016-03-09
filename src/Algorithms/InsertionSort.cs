using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Algorithms
{
    public class InsertionSort
    {
        public int[] Sort(int[] A)
        {

            for (int j = 1; j < A.Length; j++)
            {
                int key = A[j];

                // Insert A[j] into the sorted sequence A[1..j-1]
                int i = j - 1;

                while (i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }

                A[i + 1] = key;
            }

            return A;
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] {
                    new int[] {  5, 2, 4, 6, 1, 3 }
                };
            }
        }

        [Theory]
        [MemberData("TestData")]
        public void IsCorrect(int[] A)
        {
            Assert.Equal(A, Sort(A));
        }
    }
}

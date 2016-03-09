using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms
{
    public class SelectionSort
    {
        public void Sort(int[] A)
        {
            int n = A.Length;

            for (int i = 0; i < n; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[min])
                    {
                        min = j;
                    }
                }

                // Swap
                int temp = A[i];
                A[i] = A[min];
                A[min] = temp;
            }
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] {
                    new int[] { 5, 2, 4, 6, 1, 3 },
                    new int[] { 1, 2, 3, 4, 5, 6 }
                };

                yield return new object[] {
                    new int[] { 31, 41, 59, 26, 41, 58 },
                    new int[] { 26, 31, 41, 41, 58, 59}
                };
            }
        }

        [Theory]
        [MemberData("TestData")]
        public void IsCorrect(int[] A, int[] e)
        {
            Sort(A);
            Assert.Equal(e, A);
        }
    }
}

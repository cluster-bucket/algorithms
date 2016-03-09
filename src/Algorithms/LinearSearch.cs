using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms
{
    public class LinearSearch
    {
        public int Search(int[] A, int v)
        {
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == v)
                {
                    return i;
                }
            }

            return -1;
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] {
                    new int[] { 5, 2, 4, 6, 1, 3 }, 6
                };

                yield return new object[] {
                    new int[] { 31, 41, 59, 26, 41, 58 }, 6
                };
            }
        }

        [Theory]
        [MemberData("TestData")]
        public void IsCorrect(int[] A, int v)
        {
            Assert.Equal(Array.IndexOf(A, v), Search(A, v));
        }
    }
}

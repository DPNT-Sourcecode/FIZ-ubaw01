using BeFaster.App.Solutions.SUM;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(-1, 1, ExpectedResult = 0)]
        public int ComputeSum_RangeTest1(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(400, 1, ExpectedResult = 0)]
        public int ComputeSum_RangeTest2(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }


        [TestCase(1, -1, ExpectedResult = 0)]
        public int ComputeSum_RangeTest3(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(1, 400, ExpectedResult = 0)]
        public int ComputeSum_RangeTest4(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }
    }
}


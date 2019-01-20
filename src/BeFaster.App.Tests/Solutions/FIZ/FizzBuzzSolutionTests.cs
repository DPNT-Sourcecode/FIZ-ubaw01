using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    class FizzBuzzSolutionTests
    {

        [TestCase(5, ExpectedResult = "12fizz4buzz")]
        public string FizzBuzzTest1(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(1, ExpectedResult = "1")]
        public string FizzBuzzTest2(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }
    }
}


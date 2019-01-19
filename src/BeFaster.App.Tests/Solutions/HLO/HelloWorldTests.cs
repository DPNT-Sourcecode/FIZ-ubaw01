using BeFaster.App.Solutions.HLO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    class HelloWorldTests
    {
        [TestCase("friend", ExpectedResult = "hello to the world")]
        public string HellowWorld(string friendName)
        {
            return HelloSolution.Hello(friendName);
        }
    }
}

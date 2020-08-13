using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Type = StrengthFaithHope.Domain.MessageContext.Type;
namespace UnitTests.Domain.MessageContext
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void Should_Be_Created()
        {
            Type type = new Type("definition test", "done_outline");

            Assert.IsInstanceOfType(type, typeof(Type));

        }
    }
}

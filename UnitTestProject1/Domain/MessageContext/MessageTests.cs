using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrengthFaithHope.Domain.MessageContext;

namespace UnitTests.Domain.MessageContext
{
    [TestClass]
    public class MessageTests
    {
        [TestMethod]
        public void Should_Be_Created()
        {
            Type type = new Type("hope", "done_outline");

            Message message = new Message("Sometimes good things fall apart so better things can fall together", type.TypeId, "Sometimes...");

            Assert.IsInstanceOfType(message, typeof(Message));
        }
    }
}

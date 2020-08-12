
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Queries;
using StrengthFaithHope.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Mocks;

namespace UnitTests.Domain.Queries
{
    [TestClass]
    public class MessageQueriesTests
    {
        [TestMethod]
        public void Should_GetAll_Return_all_indexed_Messages()
        {
            IMessageRepository messageQueries = new MessageQueriesMock();

            IEnumerable<Message> messages = messageQueries.GetAll();

            Assert.IsTrue(messages.Count()> 0);
        }
    }
}

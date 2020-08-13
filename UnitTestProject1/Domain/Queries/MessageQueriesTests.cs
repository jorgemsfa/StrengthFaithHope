
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Queries;
using StrengthFaithHope.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Mocks;

namespace UnitTests.Domain.Queries
{
    

    [TestClass]
    public class MessageQueriesTests
    {
        private IMessageRepository _messageQueries;
        public MessageQueriesTests()
        {
            _messageQueries = new MessageQueriesMock();
        }

        [TestMethod]
        public void Should_Create_Message_Return_true()
        { 
           Boolean ret= _messageQueries.Create(MessageQueriesMock.messageCreated);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void Should_GetAll_Return_all_indexed_Messages()
        {           

            IEnumerable<Message> messages = _messageQueries.GetAll();

            Assert.IsTrue(messages.Count()> 0);
        }

    }
}

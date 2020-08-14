using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Queries;
using StrengthFaithHope.Domain.Repositories;
using System;
using System.Collections.Generic;
using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace UnitTests.Mocks
{
    public class MessageQueriesMock : IMessageRepository
    {
        private readonly IList<Message> _messages;
        public static Type type = new Type("test", "done_outline");
        public static Message messageCreated = new Message("sentece teste 1111", type.TypeId, "111");
        public MessageQueriesMock()
        {       
            _messages = new List<Message>();

            Message message1 = new Message("sentece teste 1111", type.TypeId,"111");
            Message message2 = new Message("sentece teste 2222", type.TypeId, "222");
            Message message3 = new Message("sentece teste 333333", type.TypeId, "3333");
            Message message4 = new Message("sentece teste 4444", type.TypeId, "4444");
            Message message5 = new Message("sentece teste 555", type.TypeId, "555");

            _messages.Add(message1);
            _messages.Add(message2);
            _messages.Add(message3);
            _messages.Add(message4);
            _messages.Add(message5);
        }

        public Boolean Create(Message message)
        {
            return true;
        }

        public IEnumerable<Message> GetAll()
        {
            return _messages;
        }
    }
}

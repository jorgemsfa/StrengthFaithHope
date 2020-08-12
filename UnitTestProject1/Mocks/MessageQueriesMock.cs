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
       
        public MessageQueriesMock()
        {
            _messages = new List<Message>();

            Type type = new Type("teste");

            Message message1 = new Message("sentece teste 1111", type.Id);
            Message message2 = new Message("sentece teste 2222", type.Id);
            Message message3 = new Message("sentece teste 333333", type.Id);
            Message message4 = new Message("sentece teste 4444", type.Id);
            Message message5 = new Message("sentece teste 555", type.Id);

            _messages.Add(message1);
            _messages.Add(message2);
            _messages.Add(message3);
            _messages.Add(message4);
            _messages.Add(message5);
        }

        public void Create(Message message)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetAll()
        {
            return _messages;
        }
    }
}

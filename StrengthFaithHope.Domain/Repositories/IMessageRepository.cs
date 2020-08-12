using StrengthFaithHope.Domain.MessageContext;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace StrengthFaithHope.Domain.Repositories
{
    public interface IMessageRepository 
    {
        IEnumerable<Message> GetAll();

        void Create(Message message);
    }
}

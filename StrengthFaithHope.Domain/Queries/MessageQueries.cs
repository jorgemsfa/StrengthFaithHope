using StrengthFaithHope.Domain.MessageContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StrengthFaithHope.Domain.Queries
{
    public static class MessageQueries
    {
        public static Expression<Func<IEnumerable<Message>, bool>> GetAll()
        {
            return x => x.Any();
        }
    }
}

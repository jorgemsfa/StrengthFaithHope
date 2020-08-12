using Microsoft.EntityFrameworkCore;
using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Repositories;
using StrengthFaithHope.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrengthFaithHope.Infra.Repositories
{
  
    public class MessageRepository : IMessageRepository
    {

        private readonly DataContext _dataContext;

        public MessageRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Message> GetAll()
        {
            return _dataContext.Messages
               .AsNoTracking();             
              
        }

        public void Create(Message message)
        {
            _dataContext.Add(message);
            _dataContext.SaveChanges();
        }
    }
}

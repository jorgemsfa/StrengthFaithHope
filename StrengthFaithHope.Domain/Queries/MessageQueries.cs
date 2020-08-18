using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Repositories;
using StrengthFaithHope.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace StrengthFaithHope.Domain.Queries
{
    public  class MessageQueries:IMessageQueries
    {
        private IMessageRepository _messageRepository;
        private ITypeQueries _typeQueries;


        public  MessageQueries(IMessageRepository messageRepository, ITypeQueries typeQueries)
        {
            _messageRepository = messageRepository;
            _typeQueries = typeQueries;
        }

        public IList<MessageViewModel> GetAll()
        {
            IList<Message> messages = _messageRepository.GetAll().ToList();

            return this.GenerateMessageViewModels(messages);
        }

        private IList<MessageViewModel> GenerateMessageViewModels(IList<Message> messages)
        {
            IList<MessageViewModel> messageViewModels = new List<MessageViewModel>();

            foreach (Message message in messages)
            {
                TypeViewModel typeViewModel = _typeQueries.GetById(message.TypeId);

                MessageViewModel messageViewModel = new MessageViewModel(message.MessageId, message.Sentence, typeViewModel, message.Title);

                messageViewModels.Add(messageViewModel);

            }

            return messageViewModels;
        }

    
    }
}

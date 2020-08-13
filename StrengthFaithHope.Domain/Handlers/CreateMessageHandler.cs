using StrengthFaithHope.Domain.Commands;
using StrengthFaithHope.Domain.Commands.Contracts;
using StrengthFaithHope.Domain.Handlers.Contracts;
using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrengthFaithHope.Domain.Handlers
{
    public class CreateMessageHandler : IHandler<CreateMessageCommand>
    {
        private IMessageRepository _messageRepository;
        public CreateMessageHandler(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public ICommandResult Handler(CreateMessageCommand command)
        {
            var message = new Message(command.Sentence, command.TypeId, command.Title);

           Boolean result = _messageRepository.Create(message);

            return new CommandResult(result);

        }
    }
}

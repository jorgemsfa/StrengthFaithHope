using StrengthFaithHope.Domain.Commands;
using StrengthFaithHope.Domain.Commands.Contracts;
using StrengthFaithHope.Domain.Handlers.Contracts;
using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Repositories;
using System;
using FluentValidation;
using Type = StrengthFaithHope.Domain.MessageContext.Type;
using FluentValidation.Results;
using System.Data;
using FluentValidation.TestHelper;

namespace StrengthFaithHope.Domain.Handlers
{
    public class CreateMessageHandler : AbstractValidator<Message>, IHandler<CreateMessageCommand> 
    {
        private IMessageRepository _messageRepository;
        private ITypeRepository _typeRepository;

        public CreateMessageHandler(IMessageRepository messageRepository, ITypeRepository typeRepository)
        {
            _messageRepository = messageRepository;
            _typeRepository = typeRepository;
        }
        public ValidationResult Handler(CreateMessageCommand command)
        {
            Message message = new Message(command.Sentence, command.TypeId, command.Title);

            Type type = _typeRepository.GetById(command.TypeId);

            RuleFor(m => m.Type).NotNull().WithMessage("The Type is empty or nullable");

            //1-I need implement a validation to repository
           Boolean result = _messageRepository.Create(message);
           
            return Validate(message);
        }

    }
}

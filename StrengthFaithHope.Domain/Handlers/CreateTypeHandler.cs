using StrengthFaithHope.Domain.Commands;
using StrengthFaithHope.Domain.Commands.Contracts;
using StrengthFaithHope.Domain.Handlers.Contracts;
using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace StrengthFaithHope.Domain.Handlers
{
    public class CreateTypeHandler : IHandler<CreateTypeCommand>
    {
        private ITypeRepository _typeRepository;
        public CreateTypeHandler(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
    
        public ICommandResult Handler(CreateTypeCommand command)
        {
            Type type = new Type(command.Definicion, command.Icon);
            Boolean result= _typeRepository.Create(type);

            return new CommandResult(result);
        }
    }
}

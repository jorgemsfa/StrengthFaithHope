using FluentValidation;
using FluentValidation.Results;
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
    public class CreateTypeHandler : AbstractValidator<Type>, IHandler<CreateTypeCommand>
    {
        private ITypeRepository _typeRepository;
        public CreateTypeHandler(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
    
        public ValidationResult Handler(CreateTypeCommand command)
        {
            Type type = new Type(command.Definicion, command.Icon);

            Boolean result= _typeRepository.Create(type);

             return Validate(type);
        }

      
    }
}

using FluentValidation;
using StrengthFaithHope.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StrengthFaithHope.Domain.MessageContext
{
    public class Type:AbstractValidator<Type>
    {

        public Type(String definicion,String icon)
        {
            Definicion = definicion;
            Icon = icon;
            TypeId = Guid.NewGuid();

            RuleFor(type => type.Definicion).NotNull().WithMessage("The Definicion is mandatory.");
            RuleFor(type => type.Icon).NotNull().WithMessage("The Icon is mandatory.");

        }

        public Guid TypeId { get; private set; }
        public String Definicion { get; private set; }
        public String Icon { get; private set; }
        public IEnumerable<Message> Message { get; private set; }
    }
}

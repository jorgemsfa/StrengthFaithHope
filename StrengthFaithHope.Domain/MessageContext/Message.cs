using StrengthFaithHope.Domain.Shared;
using System;
using FluentValidation;
using System.Data;

namespace StrengthFaithHope.Domain.MessageContext
{
    public class Message : AbstractValidator<Message>
    {
        public Message(String sentence, Guid typeId, String title)
        {
            Sentence = sentence;          
            TypeId = typeId;
            Title = title;
            MessageId = Guid.NewGuid();

            RuleFor(message => message.Sentence).NotNull().WithMessage("The Sentence is mandatory.");
            RuleFor(message => message.TypeId).NotNull().WithMessage("The Type is mandatory.");
            RuleFor(message => message.Title).NotNull().WithMessage("The Title is mandatory.");

        }

        public Guid MessageId { get; private set; }
        public String Sentence { get; private set; }       
        public Guid TypeId { get; private set; }
        public Type Type { get; private set; }
        public String Title { get; private set; }



    }
}

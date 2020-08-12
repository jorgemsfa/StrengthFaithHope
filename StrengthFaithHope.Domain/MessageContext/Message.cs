using StrengthFaithHope.Domain.Shared;
using System;

namespace StrengthFaithHope.Domain.MessageContext
{
    public class Message: Entity
    {
        public Message(String sentence, Guid typeId)
        {
            Sentence = sentence;          
            TypeId = typeId;
        }

        public String Sentence { get; private set; }       
        public Guid TypeId { get; private set; }
    }
}

using StrengthFaithHope.Domain.Shared;
using System;

namespace StrengthFaithHope.Domain.MessageContext
{
    public class Message: Entity
    {
        public Message(String sentence, Guid typeId, String title)
        {
            Sentence = sentence;          
            TypeId = typeId;
            Title = title;
        }

        public String Sentence { get; private set; }       
        public Guid TypeId { get; private set; }
        public String Title { get; private set; }
      

    }
}

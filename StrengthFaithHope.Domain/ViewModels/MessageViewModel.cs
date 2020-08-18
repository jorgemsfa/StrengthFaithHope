using System;
using System.Collections.Generic;
using System.Text;
using Type = StrengthFaithHope.Domain.MessageContext.Type;
using StrengthFaithHope.Domain.MessageContext;

namespace StrengthFaithHope.Domain.ViewModels
{
    public class MessageViewModel
    {
        public MessageViewModel(Guid messageId, string sentence, TypeViewModel typeViewModel, string title)
        {
            MessageId = messageId;
            Sentence = sentence;
            TypeViewModel = typeViewModel;
            Title = title;
        }

        public Guid MessageId { get;  set; }
        public String Sentence { get;  set; }
        public TypeViewModel TypeViewModel { get;  set; }
        public String Title { get;  set; }

    }

}

using StrengthFaithHope.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace StrengthFaithHope.Domain.Commands
{
    public class CreateMessageCommand:ICommand
    {
       
        public String Sentence { get; set; }

     
        public Guid TypeId { get; set; }

    }
}

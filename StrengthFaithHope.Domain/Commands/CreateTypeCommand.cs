using StrengthFaithHope.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrengthFaithHope.Domain.Commands
{
    public class CreateTypeCommand:ICommand
    {
        public String Definicion { get;  set; }
        public String Icon { get;  set; }
    }
}

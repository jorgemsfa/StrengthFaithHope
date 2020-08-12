using StrengthFaithHope.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrengthFaithHope.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public CommandResult(bool success)
        {
            Success = success;
        }

        public Boolean Success { get; private set; }
    }
}

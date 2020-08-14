using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrengthFaithHope.Domain.Commands.Contracts
{
    public interface ICommandResult
    {
        Boolean Valid();
    }
}

using FluentValidation.Results;
using StrengthFaithHope.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Text;


namespace StrengthFaithHope.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T: ICommand
    {
        ValidationResult Handler(T command);
    }
}

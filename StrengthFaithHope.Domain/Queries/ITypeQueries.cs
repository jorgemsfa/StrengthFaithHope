using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.ViewModels;
using System;
using System.Collections.Generic;
using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace StrengthFaithHope.Domain.Queries
{
    public interface ITypeQueries
    {
        IList<TypeViewModel> GetAll();

        TypeViewModel GetById(Guid typeId);
    }
}
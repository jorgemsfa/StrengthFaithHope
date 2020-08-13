using StrengthFaithHope.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace StrengthFaithHope.Domain.Repositories
{
    public interface ITypeRepository
    {

        Boolean Create(Type type);
        IEnumerable<Type> GetAll();
    }
}

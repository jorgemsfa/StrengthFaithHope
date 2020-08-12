using System;
using System.Collections.Generic;
using System.Text;

namespace StrengthFaithHope.Domain.Shared
{

    public abstract class  Entity
    {
        public Guid Id { get; private set; }
    }
}

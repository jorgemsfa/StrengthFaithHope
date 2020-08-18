using System;
using System.Collections.Generic;
using System.Text;
using StrengthFaithHope.Domain.ViewModels;

namespace StrengthFaithHope.Domain.Queries
{
    public interface IMessageQueries
    {
        IList<MessageViewModel> GetAll();

    }
}

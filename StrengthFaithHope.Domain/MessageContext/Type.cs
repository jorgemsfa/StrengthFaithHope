using StrengthFaithHope.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrengthFaithHope.Domain.MessageContext
{
    public class Type:Entity
    {
        public Type(String definicion)
        {
            Definicion = definicion;
        }

        public String Definicion { get; private set; }

    }
}

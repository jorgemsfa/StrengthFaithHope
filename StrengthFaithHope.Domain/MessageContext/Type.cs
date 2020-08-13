using StrengthFaithHope.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrengthFaithHope.Domain.MessageContext
{
    public class Type:Entity
    {
        public Type(String definicion,String icon)
        {
            Definicion = definicion;
            Icon = icon;
        }

        public String Definicion { get; private set; }
        public String Icon { get; private set; }
    }
}

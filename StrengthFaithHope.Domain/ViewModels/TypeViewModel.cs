using System;
using System.Collections.Generic;
using System.Text;

namespace StrengthFaithHope.Domain.ViewModels
{
    public class TypeViewModel
    {
        public TypeViewModel(Guid typeId, string definicion, string icon)
        {
            TypeId = typeId;
            Definicion = definicion;
            Icon = icon;
        }

        public Guid TypeId { get; set; }
        public String Definicion { get; set; }
        public String Icon { get; set; }
    
    }
}

using StrengthFaithHope.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace UnitTests.Mocks
{
    public class TypeQueriesMock:ITypeRepository
    {
        private readonly IList<Type> _types;

        public static Type typeCreated = new Type("definition created", "done_outline");

        public TypeQueriesMock()
        {
            _types = new List<Type>();

            Type type1 = new Type("definition 11", "done_outline");
            Type type2 = new Type("definition 22", "done_outline");
            Type type3 = new Type("definition 33", "done_outline");
            Type type4 = new Type("definition 44", "done_outline");
            Type type5 = new Type("definition 55", "done_outline");

            _types.Add(type1);
            _types.Add(type2);
            _types.Add(type3);
            _types.Add(type4);
            _types.Add(type5);

        }

        public Boolean Create(Type type)
        {
            return true;
        }

        public IEnumerable<Type> GetAll()
        {
            return _types;
        }

        public Type GetById(Guid typeId)
        {
            return _types.AsQueryable().FirstOrDefault(r => r.TypeId == typeId);
        }

       
    }
}

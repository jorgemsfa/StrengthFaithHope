using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrengthFaithHope.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTests.Mocks;
using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace UnitTests.Domain.Queries
{
    [TestClass]
    public class TypeQueriesTests
    {
        private ITypeRepository _typeRepository;

        public TypeQueriesTests()
        {
            _typeRepository = new TypeQueriesMock();
        }

        [TestMethod]
        public void Should_Create_Type_Return_true() 
        {
            Boolean ret= _typeRepository.Create(TypeQueriesMock.typeCreated);

            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void Should_GetAll_Return_all_indexes_Types()
        {
            IEnumerable<Type> _types = _typeRepository.GetAll();

            Assert.IsTrue(_types.Count() > 0);
        }
    }
}

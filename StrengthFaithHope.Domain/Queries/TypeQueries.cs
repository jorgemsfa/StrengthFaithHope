using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using StrengthFaithHope.Domain.Repositories;
using StrengthFaithHope.Domain.ViewModels;
    using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace StrengthFaithHope.Domain.Queries
{
    public class TypeQueries : ITypeQueries
    {
        private ITypeRepository _typeRepository;

        public TypeQueries(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
        public IList<TypeViewModel> GetAll()
        {
            IList<Type> types = _typeRepository.GetAll().ToList();

            return this.GenerateTypeViewModels(types);
        }

        public TypeViewModel GetById(Guid typeId)
        {
            Type type = _typeRepository.GetById(typeId);

            return new TypeViewModel(type.TypeId, type.Definicion, type.Icon);
        }

        private IList<TypeViewModel> GenerateTypeViewModels(IList<Type> types)
        {
            IList<TypeViewModel> typeViewModels = new List<TypeViewModel>();

            foreach (Type type in types)
            {
                TypeViewModel typeViewModel = new TypeViewModel(type.TypeId, type.Definicion, type.Icon);

                typeViewModels.Add(typeViewModel);
            }

            return typeViewModels;

        }

    }

}

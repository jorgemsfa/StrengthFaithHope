﻿using Microsoft.EntityFrameworkCore;
using StrengthFaithHope.Domain.Repositories;
using StrengthFaithHope.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using Type = StrengthFaithHope.Domain.MessageContext.Type;


namespace StrengthFaithHope.Infra.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        private DataContext _dataContext;
        public TypeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Boolean Create(Type type)
        {
            _dataContext.Add(type);
           int saved= _dataContext.SaveChanges();

           return saved == 1 ? true : false;
        }

        public IEnumerable<Type> GetAll()
        {          
            return _dataContext.Type.AsNoTracking();
        }

        public Type GetById(Guid typeId)
        {
            return _dataContext.Type.Where(r => r.TypeId == typeId).FirstOrDefault();
        }
    }
}

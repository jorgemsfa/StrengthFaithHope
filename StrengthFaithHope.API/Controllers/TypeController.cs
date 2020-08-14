using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using StrengthFaithHope.Domain.Commands;
using StrengthFaithHope.Domain.Commands.Contracts;
using StrengthFaithHope.Domain.Handlers;
using StrengthFaithHope.Domain.Repositories;
using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace StrengthFaithHope.API.Controllers
{
    [ApiController]
    [Route("V1/StrengthFaithHope/[controller]")]
    public class TypeController : Controller
    {
        [Route("")]
        [HttpPost]
       public ValidationResult Create(
           [FromBody] CreateTypeCommand createTypeCommand,
           [FromServices] CreateTypeHandler createTypeHandler)  
        {
           return createTypeHandler.Handler(createTypeCommand);
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<Type> GetAll([FromServices] ITypeRepository typeRepository)
        {
            return typeRepository.GetAll();
        }
    }
}

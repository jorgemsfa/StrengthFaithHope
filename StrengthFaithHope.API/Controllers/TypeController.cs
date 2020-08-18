using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StrengthFaithHope.Domain.Commands;
using StrengthFaithHope.Domain.Commands.Contracts;
using StrengthFaithHope.Domain.Handlers;
using StrengthFaithHope.Domain.Repositories;
using Type = StrengthFaithHope.Domain.MessageContext.Type;
using FluentValidation.Results;
using StrengthFaithHope.Domain.ViewModels;
using StrengthFaithHope.Domain.Queries;

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
        public IList<TypeViewModel> GetAll([FromServices] ITypeQueries typeQueries)
        {
            return typeQueries.GetAll().ToList();
        }
    }
}

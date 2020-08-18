using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StrengthFaithHope.Domain.Commands;
using StrengthFaithHope.Domain.Commands.Contracts;
using StrengthFaithHope.Domain.Handlers;
using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Queries;
using StrengthFaithHope.Domain.Repositories;
using StrengthFaithHope.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Threading.Tasks;

using Type = StrengthFaithHope.Domain.MessageContext.Type;

namespace StrengthFaithHope.API.Controllers
{

    [ApiController]

    [Route("V1/StrengthFaithHope/[controller]")]   
    public class MessageController: ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IList<MessageViewModel> GetAll([FromServices] IMessageQueries  messageQueries)
        {
            return messageQueries.GetAll();
        }

     

        [Route("")]
        [HttpPost]
        public ValidationResult Create( 
            [FromBody] CreateMessageCommand createMessageCommand,
            [FromServices]CreateMessageHandler createMessageHandler)
        {
           return createMessageHandler.Handler(createMessageCommand);
        }
    }
}

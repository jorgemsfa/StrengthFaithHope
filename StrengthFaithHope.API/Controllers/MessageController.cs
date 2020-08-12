﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StrengthFaithHope.Domain.Commands;
using StrengthFaithHope.Domain.Commands.Contracts;
using StrengthFaithHope.Domain.Handlers;
using StrengthFaithHope.Domain.MessageContext;
using StrengthFaithHope.Domain.Queries;
using StrengthFaithHope.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Threading.Tasks;

namespace StrengthFaithHope.API.Controllers
{

    [ApiController]

    [Route("V1/StrengthFaithHope")]   
    public class MessageController: ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Message> GetAll([FromServices] IMessageRepository messageRepository)
        {
            return messageRepository.GetAll();
        }

        [Route("")]
        [HttpPost]
        public ICommandResult Create( 
            [FromBody] CreateMessageCommand createMessageCommand,
            [FromServices]CreateMessageHandler createMessageHandler)
        {
           return createMessageHandler.Handler(createMessageCommand);
        }
    }
}
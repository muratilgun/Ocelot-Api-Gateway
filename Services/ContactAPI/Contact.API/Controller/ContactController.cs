﻿using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{id}")]
        public ContactDTO Get(int id)
        {
            return _contactService.GetContactById(id);
        }
    }

}

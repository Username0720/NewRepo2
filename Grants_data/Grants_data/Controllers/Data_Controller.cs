﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grants_data.Models;

namespace Grants_data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Data_Controller : ControllerBase
    {
        ApplicationContext db;
        public Data_Controller(ApplicationContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Data_>>> Get()
        {
            return await db.Data_s.ToListAsync();
        }

        // GET api/Friends/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Data_>> Get(string konkurs_name)
        {
            Data_ Data = await db.Data_s.FirstOrDefaultAsync(x => x.konkurs_name == konkurs_name);
            if (Data == null)
                return NotFound();
            return new ObjectResult(Data);
        }
    }
}

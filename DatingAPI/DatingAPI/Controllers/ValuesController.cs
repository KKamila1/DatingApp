using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext dataContext;
        public ValuesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        //Get api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values =await dataContext.Values.ToListAsync();
            return Ok(values);
        }

        //reszta
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var values = await dataContext.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(values);
        }
    }
}
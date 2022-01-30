using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using rest.src.Models;
using rest.src.Services;

namespace rest.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController
    {
        private readonly ILogger<UserController> _logger;
        private readonly TypicodeService _typicode;

        public UserController(ILogger<UserController> logger, TypicodeService tropiPay)
        {
            _logger = logger;
            _typicode = tropiPay;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _typicode.GetUsersAsync();
                
                return null;//Ok(result)
            }
            catch (HttpRequestException)
            {
                return null; //NotFound();
            }
        }
    }
}
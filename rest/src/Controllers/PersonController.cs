using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using rest.src.Models.DTO;
using rest.src.Services;

namespace rest.src.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private readonly TypicodeService _typicode;

    public PersonController(ILogger<PersonController> logger, TypicodeService tropiPay)
    {
        _logger = logger;
        _typicode = tropiPay;
    }

    /// <summary>
    /// Documentation
    /// </summary>
    [Route("load")]
    [HttpGet]
    public async Task<IActionResult> Load()
    {
        try
        {
            var result = await _typicode.GetUsersAsync();
            return Ok(result);
        }
        catch (HttpRequestException)
        {
            return NotFound();
        }
    }
}

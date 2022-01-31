using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using rest.src.Models.ORM;
using rest.src.Models.Repository;
using rest.src.Services;

namespace rest.src.Controllers
{
    [Route("api/[controller]")] 
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class UserController : AbstractApiController<User, RepositoryInterface<User>>
    {
        public UserController(RepositoryInterface<User> repository) : base(repository)
        {

        }
    }
}
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using rest.src.Models.ORM;
using rest.src.Models.Repository;

namespace rest.src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public abstract class AbstractApiController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : RepositoryInterface<TEntity>
    {
        private readonly TRepository _repository;

        public AbstractApiController(TRepository repository)
        {
            _repository = repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repository.List();
            return Ok(result);
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _repository.Select(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
        {
            if (id != entity.id)
            {
                return BadRequest();
            }
            var result = await _repository.Update(entity);
            return Ok(result);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<IActionResult> Post(TEntity entity)
        {
            var result = await _repository.Create(entity);
            return Ok(result); 
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _repository.Delete(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

    }
}
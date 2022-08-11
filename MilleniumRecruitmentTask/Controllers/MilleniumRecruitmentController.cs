using Microsoft.AspNetCore.Mvc;
using MilleniumRecruitmentTask.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MilleniumRecruitmentTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MyMDBController<TEntity, TRepository> : ControllerBase
       where TEntity : class, IEntity
       where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public MyMDBController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var value = await repository.Get(id);
            return value == null ? NotFound() : (ActionResult<TEntity>)value;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity value)
        {
            if (id != value.Id)
            {
                return BadRequest();
            }
            await repository.Update(value);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity value)
        {
            await repository.Add(value);
            return CreatedAtAction("Get", new { id = value.Id }, value);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var value = await repository.Delete(id);
            return value == null ? NotFound() : (ActionResult<TEntity>)value;
        }

    }
}

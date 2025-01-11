using ApplicationLayer.Dtos;
using ApplicationLayer.Services;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseModel
    {
        private readonly IBaseService<T> _service;
        public BaseController(IBaseService<T> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var entities =  await _service.GetAllAsync();
            return Ok(entities);
        }

        [HttpPost]
        public async Task<ActionResult> Create(T entity)
        {
            await _service.AddAsync(entity);
            return CreatedAtAction(nameof(GetById),new  { id = entity.Id }, entity) ;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id , T entity)
        {
            await  _service.UpdateAsync(id , entity);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            await _service.GetByIdAsync(id);
            return NoContent();
        }

    }
}

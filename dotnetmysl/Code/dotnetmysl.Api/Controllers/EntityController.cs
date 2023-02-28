using System.Collections.Generic;
using dotnetmysl.Business.Interfaces;
using dotnetmysl.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotnetmysl.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        IEntityService _EntityService;
        public EntityController(IEntityService EntityService)
        {
            _EntityService = EntityService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Entity>> Get()
        {
            return Ok(_EntityService.GetAll());
        }

        [HttpPost]
        public ActionResult<Entity> Save(Entity Entity)
        {
            return Ok(_EntityService.Save(Entity));

        }

        [HttpPut]
        public ActionResult<Entity> Update( Entity Entity)
        {
            return Ok(_EntityService.Update(Entity));

        }

        [HttpDelete]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(_EntityService.Delete(id));

        }
        [HttpGet("{id:int}")]
        public ActionResult<Entity> GetById(int id)
        {
            return Ok(_EntityService.GetById(id));
        }

    }
}

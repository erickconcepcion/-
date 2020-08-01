using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Common.DTO;
using Common.Services.Infrastructure;

namespace Common.WebApi.Controllers
{
    [RoutePrefix("personas")]
    [Authorize]
    public class PersonasController : BaseApiController
    {
        protected readonly IPersonaService PersonaService;
        public PersonasController(IPersonaService PersonaService)
        {
            this.PersonaService = PersonaService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            return Ok(await PersonaService.GetList());
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            return Ok(await PersonaService.GetById(id));
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] PersonaDTO create)
        {
            return Ok(await PersonaService.Create(create));
        }

        [HttpPut]
        public async Task<IHttpActionResult> Put([FromBody] PersonaDTO edit)
        {
            await PersonaService.Edit(edit);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            await PersonaService.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}

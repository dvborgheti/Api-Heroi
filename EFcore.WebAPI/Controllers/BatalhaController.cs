using EFcore.WebAPI.Models;
using EFcore.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EFcore.WebAPI.Controllers
{
    [ApiController]
    [Route("v1/batalha")]
    public class BatalhaController : ControllerBase
    {
        private readonly IBatalhaServices _batalhaService;

        public BatalhaController(IBatalhaServices batalhaService)
        {
            _batalhaService = batalhaService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Batalha>>> Get()
        {
            var list = await _batalhaService.Get();

            if (list == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(list);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Batalha>> Get(int id)
        {
            var obj = await _batalhaService.Get(id);

            if(obj == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(obj);
            }
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Batalha>> Post([FromBody] Batalha batalha)
        {
            var response = await _batalhaService.Post(batalha);
            return response;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Batalha>> Delete(int id)
        {
            var response = await _batalhaService.Delete(id);

            if(response == true)
            {
                return Ok("Batalha deletada com sucesso");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

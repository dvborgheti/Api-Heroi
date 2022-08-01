using EFcore.WebAPI.Models;
using EFcore.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EFcore.WebAPI.Controllers
{
    [ApiController]
    [Route("v1/heroi")]
    public class HeroiController : ControllerBase
    {
        private readonly IHeroiServices _heroiService;

        public HeroiController(IHeroiServices heroiService)
        {
            _heroiService = heroiService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Heroi>>> Get()
        {
            var list = await _heroiService.Get();

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
        public async Task<ActionResult<Heroi>> Get(int id)
        {
            var obj = await _heroiService.Get(id);

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
        public async Task<ActionResult<Heroi>> Post([FromBody] Heroi heroi)
        {
            var response = await _heroiService.Post(heroi);
            return response;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Heroi>> Delete(int id)
        {
            var response = await _heroiService.Delete(id);

            if(response == true)
            {
                return Ok("Herói deletado com sucesso");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

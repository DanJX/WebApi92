using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AutoresController : Controller
    {
        private readonly IAutorServices _autorServices;

        public AutoresController(IAutorServices autorServices)
        {
            _autorServices = autorServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAutores()
        {
            var response = await _autorServices.GetAutores();
            return Ok(response);
        }
    }
}

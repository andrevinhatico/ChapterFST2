using ChapterFST2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterFST2.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livrorepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livrorepository = livroRepository;
        }

        [HttpGet]
        public  IActionResult Listar()
        {
            try
            {
                return Ok(_livrorepository.Listar());
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}

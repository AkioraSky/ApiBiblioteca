using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class BibliotecaController : ControllerBase
    {
        [HttpGet]
        [Route("TraerUsuarios")]
        public string func_sasa()
        {
            string name = "";
            string json = ClaseFunciones.Func_Traer_Usuario(name);
            return json;
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    public class MarcacionController : ControllerBase
    {
        [Route("api/marcacion/crear")]
        [HttpPost]
        public ActionResult Crear()
        {
            return Ok("Respuesta OK");
        }

        [Route("api/marcacion/obtener")]
        [HttpGet]
        public ActionResult Obtener()
        {
            return Ok("Respuesta OK");
        }

        [Route("api/marcacion/actualizar")]
        [HttpPut]
        public ActionResult Actualizar(int id)
        {
            return Ok("Respuesta OK");
        }

        [Route("api/marcacion/eliminar")]
        [HttpDelete]
        public ActionResult Eliminar(int id)
        {
            return Ok("Respuesta OK");
        }
    }
}

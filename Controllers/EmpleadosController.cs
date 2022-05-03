using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestApi.Models;

namespace TestApi.Controllers
{
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        [Route("api/obtenerEmpleados")]
        [HttpGet]
        public ActionResult obtenerEmpleados()
        {
            var objetoEmpleados = new RootObject();
            objetoEmpleados.empleados = new List<EmpleadoDto>
            {
                new EmpleadoDto { id = 1, nombre = "Betsy", edad = 30, salario = 1600},
                new EmpleadoDto { id = 2, nombre = "Ana", edad = 20, salario = 180},
                new EmpleadoDto { id = 3, nombre = "Camila", edad = 30, salario = 220},
                new EmpleadoDto { id = 4, nombre = "Pedro", edad = 40, salario = 342},
                new EmpleadoDto { id = 5, nombre = "Jorge", edad = 30, salario = 657}
            };

            var respuesta = JsonConvert.SerializeObject(objetoEmpleados.empleados);
           
            return Ok(respuesta);

        }

        [Route("api/obtenerEmpleado")]
        [HttpGet]
        public ActionResult obtenerEmpleados(int idEmpleado)
        {
            var objetoEmpleados = new RootObject();
            objetoEmpleados.empleados = new List<EmpleadoDto>
            {
                new EmpleadoDto { id = 1, nombre = "Betsy", edad = 30, salario = 1600},
                new EmpleadoDto { id = 2, nombre = "Ana", edad = 20, salario = 180},
                new EmpleadoDto { id = 3, nombre = "Camila", edad = 30, salario = 220},
                new EmpleadoDto { id = 4, nombre = "Pedro", edad = 40, salario = 342},
                new EmpleadoDto { id = 5, nombre = "Jorge", edad = 30, salario = 657}
            };

            EmpleadoDto empleado = new EmpleadoDto();
            foreach (var item in objetoEmpleados.empleados)
            {
                if (item.id == idEmpleado)
                {
                    empleado.id = item.id;
                    empleado.nombre = item.nombre;
                    empleado.edad = item.edad;
                    empleado.salario = item.salario;
                }

            }

            var respuesta = JsonConvert.SerializeObject(empleado);

            return Ok(respuesta);

        }
    }
}

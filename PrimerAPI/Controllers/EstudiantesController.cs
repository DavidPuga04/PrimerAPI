using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimerAPI.Interfaz;
using PrimerAPI.Modelos;
using PrimerAPI.Repositories;

namespace PrimerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        IEstudianteRepository _estudianteRepository;
        public EstudiantesController()
        {
            _estudianteRepository = new EstudianteRepository();
        }

        [HttpGet]
        public IActionResult DevuelveListadoEstudiantes()
        {
            var estudiantes = _estudianteRepository.DevuelveListadoEstudiantes();
            return Ok(estudiantes);
        }

        [Route("InfoEstudiante/{BannerId}")] 
        [HttpGet]
        public IActionResult DevuelveInformacionEstudiante(string BannerId)
        {
            try
            {
                var infoEstudiante = _estudianteRepository.DevuelveInformacionEstudiante(BannerId);
                return Ok(infoEstudiante);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult GuardarEstudiante([FromBody] Estudiante estudiante)
        {
            try
            {
                var guardar = _estudianteRepository.GuardarEstudiante(estudiante);
                if (guardar)
                {
                    return Ok();
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}

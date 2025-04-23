using PrimerAPI.Interfaz;
using PrimerAPI.Modelos;

namespace PrimerAPI.Repositories
{
    public class EstudianteRepository : IEstudianteRepository
    {
        public Estudiante DevuelveInformacionEstudiante(string BannerId)
        {
            var estudiantes = DevuelveListadoEstudiantes();
            return estudiantes.First(item => item.BannerId == BannerId);
        }

        public IEnumerable<Estudiante> DevuelveListadoEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            Estudiante estudiante1 = new Estudiante
            {
                BannerId = "12345",
                Nombre = "David",
                Edad = 30,
                TieneBeca = true
            };
            estudiantes.Add(estudiante1);

            Estudiante estudiante2 = new Estudiante
            {
                BannerId = "45678",
                Nombre = "Alex",
                Edad = 24,
                TieneBeca = false
            };
            estudiantes.Add(estudiante2);
            return estudiantes;
        }

        public bool GuardarEstudiante(Estudiante estudiante)
        {
            return true;
        }
    }
}

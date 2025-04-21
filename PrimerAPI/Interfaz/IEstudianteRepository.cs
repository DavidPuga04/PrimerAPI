using PrimerAPI.Modelos;

namespace PrimerAPI.Interfaz
{
    public interface IEstudianteRepository
    {
        IEnumerable<Estudiante> DevuelveListadoEstudiantes();
        Estudiante DevuelveInformacionEstudiante(string BannerId);
    }
}

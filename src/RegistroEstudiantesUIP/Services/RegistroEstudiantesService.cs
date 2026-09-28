using RegistroEstudiantesUIP.Models;

namespace RegistroEstudiantesUIP.Services;

public sealed class RegistroEstudiantesService
{
    private readonly List<Estudiante> _estudiantes = [];

    public IReadOnlyList<Estudiante> Estudiantes => _estudiantes;

    public ResultadoRegistro Registrar(string idTexto, string nombre, string carrera)
    {
        idTexto = idTexto.Trim();
        nombre = nombre.Trim();
        carrera = carrera.Trim();

        if (string.IsNullOrWhiteSpace(idTexto) ||
            string.IsNullOrWhiteSpace(nombre) ||
            string.IsNullOrWhiteSpace(carrera))
        {
            return new ResultadoRegistro(false, "Debe completar todos los campos.");
        }

        if (!int.TryParse(idTexto, out int id) || id <= 0)
        {
            return new ResultadoRegistro(
                false,
                "El ID del estudiante debe ser un número entero mayor que cero.");
        }

        if (nombre.Length < 3)
        {
            return new ResultadoRegistro(
                false,
                "El nombre debe contener al menos 3 caracteres.");
        }

        if (_estudiantes.Any(estudiante => estudiante.Id == id))
        {
            return new ResultadoRegistro(
                false,
                "Ya existe un estudiante con ese ID.");
        }

        var nuevoEstudiante = new Estudiante(id, nombre, carrera);
        _estudiantes.Add(nuevoEstudiante);

        return new ResultadoRegistro(
            true,
            $"Estudiante '{nuevoEstudiante.Nombre}' agregado correctamente.",
            nuevoEstudiante);
    }
}

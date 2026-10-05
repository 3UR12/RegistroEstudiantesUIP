using RegistroEstudiantesUIP.Models;

namespace RegistroEstudiantesUIP.Services;

public sealed class RegistroEstudiantesService
{
    private readonly List<Estudiante> _estudiantes = [];

    public IReadOnlyList<Estudiante> Estudiantes => _estudiantes;

    public ResultadoRegistro Registrar(string idTexto, string nombre, string carrera)
    {
        var validacion = ValidarDatos(idTexto, nombre, carrera);
        if (!validacion.Exito || validacion.Estudiante is null)
        {
            return validacion;
        }

        var nuevoEstudiante = validacion.Estudiante;

        if (_estudiantes.Any(estudiante => estudiante.Id == nuevoEstudiante.Id))
        {
            return new ResultadoRegistro(
                false,
                "Ya existe un estudiante con ese ID.");
        }

        _estudiantes.Add(nuevoEstudiante);

        return new ResultadoRegistro(
            true,
            $"Estudiante '{nuevoEstudiante.Nombre}' agregado correctamente.",
            nuevoEstudiante);
    }

    public ResultadoRegistro Actualizar(
        int idOriginal,
        string idTexto,
        string nombre,
        string carrera)
    {
        var existente = _estudiantes.FirstOrDefault(estudiante => estudiante.Id == idOriginal);
        if (existente is null)
        {
            return new ResultadoRegistro(false, "No se encontró el registro seleccionado.");
        }

        var validacion = ValidarDatos(idTexto, nombre, carrera);
        if (!validacion.Exito || validacion.Estudiante is null)
        {
            return validacion;
        }

        var actualizado = validacion.Estudiante;

        if (_estudiantes.Any(estudiante =>
                estudiante.Id == actualizado.Id && estudiante.Id != idOriginal))
        {
            return new ResultadoRegistro(
                false,
                "Ya existe otro estudiante con ese ID.");
        }

        int indice = _estudiantes.IndexOf(existente);
        _estudiantes[indice] = actualizado;

        return new ResultadoRegistro(
            true,
            $"Estudiante '{actualizado.Nombre}' actualizado correctamente.",
            actualizado);
    }

    public ResultadoRegistro Eliminar(int id)
    {
        var existente = _estudiantes.FirstOrDefault(estudiante => estudiante.Id == id);
        if (existente is null)
        {
            return new ResultadoRegistro(false, "No se encontró el registro seleccionado.");
        }

        _estudiantes.Remove(existente);

        return new ResultadoRegistro(
            true,
            $"Estudiante '{existente.Nombre}' eliminado correctamente.",
            existente);
    }

    private static ResultadoRegistro ValidarDatos(
        string idTexto,
        string nombre,
        string carrera)
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

        if (idTexto.Length > 10)
        {
            return new ResultadoRegistro(
                false,
                "El ID del estudiante no puede superar 10 dígitos.");
        }

        if (nombre.Length is < 3 or > 80)
        {
            return new ResultadoRegistro(
                false,
                "El nombre debe contener entre 3 y 80 caracteres.");
        }

        bool nombreValido = nombre.All(caracter =>
            char.IsLetter(caracter) ||
            char.IsWhiteSpace(caracter) ||
            caracter is '-' or '\'' or '.');

        if (!nombreValido)
        {
            return new ResultadoRegistro(
                false,
                "El nombre contiene caracteres no permitidos.");
        }

        if (carrera.Length > 80 || carrera.Any(char.IsControl))
        {
            return new ResultadoRegistro(false, "La carrera seleccionada no es válida.");
        }

        return new ResultadoRegistro(
            true,
            "Datos válidos.",
            new Estudiante(id, nombre, carrera));
    }
}

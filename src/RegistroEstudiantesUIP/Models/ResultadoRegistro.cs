namespace RegistroEstudiantesUIP.Models;

public sealed record ResultadoRegistro(
    bool Exito,
    string Mensaje,
    Estudiante? Estudiante = null);

# Historial de cambios

## v1.0.0 — 29 de septiembre de 2026

### Aplicación

- Registro de estudiantes por ID, nombre y carrera.
- Validación de campos obligatorios.
- Validación de ID numérico y mayor que cero.
- Control de IDs duplicados.
- DataGridView para visualizar registros.
- Contador de registros y botón Limpiar.
- Interfaz final con distribución y estilos unificados.

### Código

- Separación entre interfaz, lógica de registro y modelos.
- Validaciones concentradas en `RegistroEstudiantesService`.
- Proyecto configurado para .NET 8 y Windows Forms.

### Compilación y publicación

- Compilación Release.
- Publicación self-contained para `win-x64`.
- Archivo único habilitado.
- Símbolos de depuración deshabilitados.
- Perfil `FolderProfile.pubxml` incluido en el proyecto.

### Entrega

- Ejecutable probado fuera de Visual Studio.
- Video de evidencia.
- Presentación final.
- Release `v1.0.0`.

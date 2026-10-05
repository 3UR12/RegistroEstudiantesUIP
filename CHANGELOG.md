# Historial de cambios

## Cambios posteriores a v1.0.0

### Aplicación

- Operaciones CRUD completas en memoria: crear, consultar, actualizar y eliminar registros.
- Selección de filas para editar o eliminar estudiantes.
- Confirmación antes de eliminar un registro.
- Validaciones adicionales de longitud y caracteres del nombre.
- Aviso visible de privacidad para utilizar datos de práctica.

### Privacidad y seguridad

- Los datos continúan almacenándose únicamente en memoria durante la sesión.
- No se agregan archivos de datos, base de datos ni conexiones externas.
- Se documenta que el repositorio es público y no debe contener información personal real.

### Documentación

- Integrantes actualizados: Euris J. Rodríguez V., Daniela Insturaín y Aaron Fechrenback.
- Redacción ajustada a un tono grupal y neutral.

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

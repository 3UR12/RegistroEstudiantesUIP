# Arquitectura

## Alcance

La aplicación registra estudiantes durante una sesión de ejecución. No utiliza base de datos ni archivos de persistencia.

La solución se divide en tres responsabilidades principales.

## Presentación

Archivos principales:

~~~text
MainForm.cs
MainForm.Designer.cs
~~~

Responsabilidades:

- capturar ID, nombre y carrera;
- mostrar mensajes de validación;
- mostrar los registros en el DataGridView;
- actualizar el contador visible de registros;
- responder a los botones Agregar y Limpiar.

## Lógica

Archivo:

~~~text
Services/RegistroEstudiantesService.cs
~~~

Responsabilidades:

- validar campos obligatorios;
- convertir y validar el ID;
- comprobar que el ID sea mayor que cero;
- validar el nombre;
- impedir IDs duplicados;
- mantener la colección de estudiantes durante la ejecución.

## Modelo

Archivos:

~~~text
Models/Estudiante.cs
Models/ResultadoRegistro.cs
~~~

Estudiante representa un registro válido.

ResultadoRegistro devuelve a la interfaz el estado de la operación, el mensaje correspondiente y el estudiante creado cuando la validación termina correctamente.

## Flujo

~~~text
Usuario
  │
  ▼
MainForm
  │  ID / nombre / carrera
  ▼
RegistroEstudiantesService
  │
  ├── validación
  ├── control de duplicados
  └── almacenamiento en memoria
  │
  ▼
ResultadoRegistro
  │
  ▼
MainForm
  │
  ├── mensaje
  └── DataGridView
~~~

## Compilación

El proyecto tiene como destino net8.0-windows.

La configuración Release desactiva símbolos de depuración.

La publicación final utiliza:

~~~text
win-x64
Self-contained / Independiente
Single file
~~~

El perfil está versionado en Properties/PublishProfiles/FolderProfile.pubxml.

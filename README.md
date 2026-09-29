# RegistroEstudiantesUIP

Aplicación de escritorio para registro temporal de estudiantes, desarrollada en C# con Windows Forms y .NET 8 para el taller práctico de Compiladores de la Universidad Interamericana de Panamá.

## Funcionalidad

La aplicación permite:

- registrar ID, nombre y carrera;
- validar campos obligatorios;
- validar que el ID sea numérico y mayor que cero;
- impedir IDs duplicados;
- mostrar los registros en un DataGridView;
- limpiar el formulario;
- mostrar mensajes de validación;
- contar los registros cargados durante la sesión.

Los datos se mantienen únicamente en memoria. No se utiliza base de datos.

## Entorno

- C#
- Windows Forms
- .NET 8
- Visual Studio 2022
- Windows x64

## Estado técnico

El flujo funcional, la compilación Release, la publicación win-x64 y la ejecución del archivo .exe fuera de Visual Studio fueron verificados en Windows el 29 de septiembre de 2026.

La rama main incluye posteriormente una revisión visual de la interfaz y una configuración de publicación reproducible. El ejecutable final debe regenerarse después de actualizar el repositorio.

## Arquitectura

~~~text
MainForm
   │
   ├── captura y presentación
   │
   ▼
RegistroEstudiantesService
   │
   ├── validaciones
   ├── control de duplicados
   └── colección en memoria
   │
   ▼
Estudiante / ResultadoRegistro
~~~

La lógica de validación se mantiene fuera del formulario para separar interfaz, reglas y modelo de datos.

## Estructura

~~~text
RegistroEstudiantesUIP/
├── .github/
│   └── workflows/
│       └── build.yml
├── docs/
│   ├── ARCHITECTURE.md
│   ├── DISTRIBUCION_Y_PROTECCION.md
│   ├── EVIDENCIA_VIDEO.md
│   ├── INSTALACION_VISUAL_STUDIO_2022.md
│   ├── PRUEBAS.md
│   └── PUBLICACION.md
├── src/
│   └── RegistroEstudiantesUIP/
│       ├── Models/
│       ├── Services/
│       ├── Properties/
│       │   └── PublishProfiles/
│       │       └── FolderProfile.pubxml
│       ├── MainForm.cs
│       ├── MainForm.Designer.cs
│       ├── Program.cs
│       └── RegistroEstudiantesUIP.csproj
├── .gitignore
├── RegistroEstudiantesUIP.sln
├── README.md
└── README.txt
~~~

## Abrir el proyecto

1. Instalar Visual Studio 2022 con la carga de trabajo **Desarrollo de escritorio de .NET**.
2. Clonar el repositorio.
3. Abrir RegistroEstudiantesUIP.sln.
4. Restaurar dependencias si Visual Studio lo solicita.
5. Ejecutar con F5 para una prueba en Debug.

La instalación completa está documentada en [docs/INSTALACION_VISUAL_STUDIO_2022.md](docs/INSTALACION_VISUAL_STUDIO_2022.md).

## Compilar en Release

En Visual Studio:

~~~text
Configuración: Release
Plataforma: Any CPU
Compilar > Compilar solución
~~~

Desde terminal:

~~~powershell
dotnet build RegistroEstudiantesUIP.sln -c Release
~~~

## Publicar para Windows x64

El repositorio incluye FolderProfile.pubxml con la configuración utilizada:

~~~text
Configuración: Release
Framework: net8.0-windows
Modo de implementación: Independiente
Runtime: win-x64
Archivo único: Sí
Trim: No
ReadyToRun: No
Símbolos de depuración: No
~~~

Desde terminal:

~~~powershell
dotnet publish src/RegistroEstudiantesUIP/RegistroEstudiantesUIP.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishTrimmed=false -p:PublishReadyToRun=false
~~~

La guía paso a paso está en [docs/PUBLICACION.md](docs/PUBLICACION.md).

## Código fuente y distribución

Un repositorio público permite consultar directamente el código fuente. La publicación en Release no cambia esa condición.

Para limitar el acceso al código del repositorio debe utilizarse un repositorio privado. Para el ejecutable distribuido se eliminan símbolos de depuración y se utiliza publicación Release en archivo único, pero una aplicación .NET no puede considerarse imposible de descompilar.

Detalles: [docs/DISTRIBUCION_Y_PROTECCION.md](docs/DISTRIBUCION_Y_PROTECCION.md).

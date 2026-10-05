REGISTRO DE ESTUDIANTES - COMPILADORES UIP
===========================================

Integrantes:
- Euris J. Rodríguez V.
- Daniela Insturaín
- Aaron Fechrenback

TECNOLOGÍA
----------
C#
Windows Forms
.NET 8
Visual Studio 2022
Windows x64

FUNCIONES
---------
- Crear registros de estudiantes.
- Consultar registros en la tabla.
- Actualizar el registro seleccionado.
- Eliminar registros con confirmación.
- Validar campos, ID y nombre.

PRIVACIDAD
----------
Los datos se mantienen solo en memoria durante la sesión.
No se guardan en archivos, bases de datos ni servicios externos.
Se recomienda utilizar información de práctica y evitar datos personales reales.

REQUISITOS
----------
- Visual Studio 2022
- Desarrollo de escritorio de .NET
- .NET 8 SDK

EJECUCIÓN DESDE VISUAL STUDIO
-----------------------------
1. Abrir RegistroEstudiantesUIP.sln.
2. Seleccionar Debug | Any CPU.
3. Ejecutar con F5.

COMPILACIÓN
-----------
Configuración: Release | Any CPU

Visual Studio:
Compilar > Compilar solución

Terminal:
dotnet build RegistroEstudiantesUIP.sln -c Release

PUBLICACIÓN
-----------
Perfil: FolderProfile
Framework: net8.0-windows
Runtime: win-x64
Modo: Self-contained
Archivo único: Sí
Trim: No
ReadyToRun: No

Salida:
src\RegistroEstudiantesUIP\bin\Release\net8.0-windows\publish\win-x64\

Ejecutable:
RegistroEstudiantesUIP.exe

RELEASE INICIAL
---------------
https://github.com/3UR12/RegistroEstudiantesUIP/releases/tag/v1.0.0

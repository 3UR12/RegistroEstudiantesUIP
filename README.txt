REGISTRO DE ESTUDIANTES - COMPILADORES UIP
===========================================

Tecnología
----------
C#
Windows Forms
.NET 8
Visual Studio 2022
Windows x64

Requisitos de desarrollo
------------------------
1. Visual Studio 2022.
2. Carga de trabajo "Desarrollo de escritorio de .NET".
3. .NET 8 SDK.

Abrir y ejecutar
----------------
1. Abrir RegistroEstudiantesUIP.sln.
2. Seleccionar Debug | Any CPU.
3. Ejecutar con F5.

Compilar para entrega
---------------------
1. Seleccionar Release | Any CPU.
2. Ir a Compilar > Compilar solución.
3. Confirmar que la compilación termine sin errores.

Publicar
--------
1. Clic derecho sobre el proyecto RegistroEstudiantesUIP.
2. Seleccionar Publicar.
3. Usar el perfil FolderProfile.
4. Verificar:
   - Configuración: Release
   - Framework: net8.0-windows
   - Modo: Independiente
   - Runtime: win-x64
   - Archivo único: activado
   - Trim: desactivado
   - ReadyToRun: desactivado
5. Presionar Publicar.

Salida esperada
---------------
src\RegistroEstudiantesUIP\bin\Release\net8.0-windows\publish\win-x64\

Validación
----------
Cerrar Visual Studio y ejecutar RegistroEstudiantesUIP.exe directamente desde la carpeta publicada.

Documentación completa
----------------------
docs\INSTALACION_VISUAL_STUDIO_2022.md
docs\PUBLICACION.md
docs\PRUEBAS.md
docs\DISTRIBUCION_Y_PROTECCION.md

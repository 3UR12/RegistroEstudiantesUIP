# Instalación y configuración de Visual Studio 2022

## Descarga

Visual Studio 2022 Community puede descargarse desde el instalador oficial de Microsoft:

- Instalador directo de Visual Studio 2022 Community: https://aka.ms/vs/17/release/vs_community.exe
- Página oficial de Visual Studio: https://visualstudio.microsoft.com/downloads/
- Descarga oficial de .NET 8: https://dotnet.microsoft.com/download/dotnet/8.0

El proyecto utiliza Visual Studio 2022, .NET 8 y Windows Forms.

## Instalación

Ejecutar vs_community.exe.

En **Cargas de trabajo**, seleccionar:

~~~text
Desarrollo de escritorio de .NET
~~~

En los componentes de instalación debe estar disponible el SDK de .NET 8. Si no aparece instalado después de finalizar Visual Studio, instalar .NET 8 SDK desde el enlace oficial indicado arriba.

## Comprobación de .NET

Abrir PowerShell o Terminal y ejecutar:

~~~powershell
dotnet --version
dotnet --list-sdks
~~~

Debe aparecer una versión 8.0.x entre los SDK instalados.

## Obtener el proyecto

Clonar:

~~~powershell
git clone https://github.com/3UR12/RegistroEstudiantesUIP.git
cd RegistroEstudiantesUIP
~~~

También puede descargarse el repositorio como ZIP desde GitHub.

## Abrir la solución

Abrir:

~~~text
RegistroEstudiantesUIP.sln
~~~

Visual Studio debe mostrar una solución con un proyecto:

~~~text
RegistroEstudiantesUIP
├── Dependencias
├── Models
├── Properties
├── Services
├── MainForm.cs
└── Program.cs
~~~

Si Visual Studio muestra una restauración de proyecto, esperar a que finalice antes de compilar.

## Ejecutar en Debug

En la barra superior seleccionar:

~~~text
Debug | Any CPU
~~~

Presionar F5.

La aplicación debe abrir la ventana **Registro de estudiantes - Compiladores UIP**.

Prueba mínima:

~~~text
ID: 1001
Nombre: Ana Pérez
Carrera: Ingeniería en Sistemas Computacionales
~~~

Al presionar **Agregar**, el registro debe aparecer en la tabla.

## Compilar en Release

Detener la depuración y cambiar Debug por Release. Mantener Any CPU.

Luego ejecutar:

~~~text
Compilar > Compilar solución
~~~

Atajo:

~~~text
Ctrl + Shift + B
~~~

La ventana **Salida** debe finalizar sin errores.

No es necesario iniciar depuración con F5 en Release para generar el ejecutable final.

## Publicación

La publicación final se realiza con el perfil incluido en:

~~~text
src\RegistroEstudiantesUIP\Properties\PublishProfiles\FolderProfile.pubxml
~~~

Configuración:

~~~text
Configuración: Release | Any CPU
Marco de destino: net8.0-windows
Modo de implementación: Independiente
Entorno de ejecución: win-x64
Archivo único: activado
Trim: desactivado
ReadyToRun: desactivado
Símbolos de depuración: desactivados
~~~

Los pasos detallados están en docs/PUBLICACION.md.

## Carpeta de salida

La ruta configurada es:

~~~text
src\RegistroEstudiantesUIP\bin\Release\net8.0-windows\publish\win-x64\
~~~

El archivo principal es:

~~~text
RegistroEstudiantesUIP.exe
~~~

## Validación final

Cerrar Visual Studio y ejecutar el .exe desde el Explorador de archivos.

Validar al menos:

1. registro válido;
2. campo obligatorio vacío;
3. ID duplicado.

La ejecución desde la carpeta publicada confirma que la aplicación funciona fuera del entorno de desarrollo.

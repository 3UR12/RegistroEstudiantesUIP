# Compilación y publicación para Windows

## Configuración utilizada

~~~text
Proyecto: RegistroEstudiantesUIP
Framework: net8.0-windows
Configuración: Release
Plataforma de compilación: Any CPU
Runtime de publicación: win-x64
Modo de implementación: Independiente
Publicación en archivo único: Sí
Trim: No
ReadyToRun: No
Símbolos de depuración: No
~~~

## Compilar Release

En Visual Studio 2022 seleccionar:

~~~text
Release | Any CPU
~~~

Ir a:

~~~text
Compilar > Compilar solución
~~~

o utilizar Ctrl + Shift + B.

Antes de publicar, la compilación debe finalizar sin errores.

## Crear el perfil de publicación manualmente

Este repositorio ya incluye FolderProfile.pubxml. Estos pasos permiten recrearlo desde Visual Studio.

En el Explorador de soluciones:

1. Clic derecho sobre el proyecto RegistroEstudiantesUIP.
2. Seleccionar **Publicar**.
3. En **¿Dónde publica hoy?**, seleccionar **Carpeta**.
4. Presionar **Siguiente**.
5. Elegir **Carpeta** como destino específico.
6. Definir una ubicación de salida.
7. Presionar **Finalizar**.

## Configurar el perfil

Abrir **Mostrar todas las configuraciones** y establecer:

~~~text
Configuración: Release | Any CPU
Marco de destino: net8.0-windows
Modo de implementación: Independiente
Entorno de ejecución de destino: win-x64
~~~

En **Opciones de publicación de archivos**:

~~~text
Producir un solo archivo: activado
Recortar ensamblados / Trim: desactivado
ReadyToRun: desactivado
~~~

Guardar el perfil.

El repositorio utiliza además:

~~~text
IncludeNativeLibrariesForSelfExtract = true
DebugType = None
DebugSymbols = false
~~~

Estas propiedades están definidas en FolderProfile.pubxml.

## Publicar

Presionar **Publicar**.

La publicación configurada genera la salida en:

~~~text
src\RegistroEstudiantesUIP\bin\Release\net8.0-windows\publish\win-x64\
~~~

## Publicar desde terminal

Desde la raíz del repositorio:

~~~powershell
dotnet publish src/RegistroEstudiantesUIP/RegistroEstudiantesUIP.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishTrimmed=false -p:PublishReadyToRun=false -p:DebugType=None -p:DebugSymbols=false
~~~

## Validar el ejecutable

1. Cerrar Visual Studio.
2. Abrir la carpeta de publicación.
3. Ejecutar RegistroEstudiantesUIP.exe.
4. Registrar un estudiante válido.
5. Probar un campo vacío.
6. Probar un ID duplicado.

No debe utilizarse únicamente la ejecución con F5 como validación final.

## Release y Publish

Release compila el proyecto con optimizaciones de compilación.

Publish prepara una salida destinada a ejecución o distribución e incorpora la configuración de runtime y dependencias seleccionada.

Para este proyecto se utiliza publicación independiente para win-x64.

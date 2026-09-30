# Visual Studio 2022

## Requisitos

- Windows
- Visual Studio 2022
- Carga de trabajo **Desarrollo de escritorio de .NET**
- .NET 8 SDK

Enlaces oficiales:

- Visual Studio: https://visualstudio.microsoft.com/downloads/
- .NET 8: https://dotnet.microsoft.com/download/dotnet/8.0

## Comprobar .NET

```powershell
dotnet --version
dotnet --list-sdks
```

Debe aparecer un SDK 8.0.x.

## Obtener el proyecto

```powershell
git clone https://github.com/3UR12/RegistroEstudiantesUIP.git
cd RegistroEstudiantesUIP
```

Abrir:

```text
RegistroEstudiantesUIP.sln
```

## Ejecutar

Seleccionar:

```text
Debug | Any CPU
```

Presionar **F5**.

Prueba rápida:

```text
ID: 1001
Nombre: Ana Pérez
Carrera: Ingeniería en Sistemas Computacionales
```

Al presionar **Agregar**, el registro debe aparecer en la tabla.

## Compilar

Seleccionar:

```text
Release | Any CPU
```

Luego:

```text
Compilar > Compilar solución
```

Atajo: `Ctrl + Shift + B`.

## Publicar

Usar el perfil:

```text
src/RegistroEstudiantesUIP/Properties/PublishProfiles/FolderProfile.pubxml
```

Salida:

```text
src/RegistroEstudiantesUIP/bin/Release/net8.0-windows/publish/win-x64/
```

Ejecutable:

```text
RegistroEstudiantesUIP.exe
```

Para la validación final, ejecutar el EXE directamente desde la carpeta publicada.

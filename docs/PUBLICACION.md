# Publicación para Windows

## Configuración

| Opción | Valor |
|---|---|
| Proyecto | RegistroEstudiantesUIP |
| Framework | net8.0-windows |
| Configuración | Release |
| Plataforma | Any CPU |
| Runtime | win-x64 |
| Implementación | Self-contained |
| Archivo único | Sí |
| Trim | No |
| ReadyToRun | No |
| Símbolos de depuración | No |

## Visual Studio

1. Seleccionar `Release | Any CPU`.
2. Ejecutar **Compilar > Compilar solución**.
3. Clic derecho en `RegistroEstudiantesUIP` → **Publicar**.
4. Seleccionar `FolderProfile`.
5. Presionar **Publicar**.

## Terminal

```powershell
dotnet publish src/RegistroEstudiantesUIP/RegistroEstudiantesUIP.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishTrimmed=false -p:PublishReadyToRun=false -p:DebugType=None -p:DebugSymbols=false
```

## Salida

```text
src/RegistroEstudiantesUIP/bin/Release/net8.0-windows/publish/win-x64/
```

Archivo principal:

```text
RegistroEstudiantesUIP.exe
```

La validación final consiste en ejecutar el EXE desde la carpeta publicada, fuera de Visual Studio.

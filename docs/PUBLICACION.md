# Compilación y publicación

## Debug

Se utiliza durante el desarrollo y la depuración.

Desde Visual Studio:

```text
Debug
F5
```

## Release

Antes de entregar:

```text
Release
Build > Build Solution
```

## Publicación desde Visual Studio

1. Clic derecho sobre el proyecto `RegistroEstudiantesUIP`.
2. Seleccionar **Publish / Publicar**.
3. Seleccionar **Folder / Carpeta**.
4. Runtime: `win-x64`.
5. Deployment mode: **Self-contained**.
6. Activar **Produce single file** si la interfaz lo ofrece.
7. Ejecutar **Publish**.

## Publicación desde terminal

```powershell
dotnet publish src/RegistroEstudiantesUIP/RegistroEstudiantesUIP.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

## Validación final

El paso obligatorio es ejecutar el archivo publicado directamente desde la carpeta de salida.

No usar únicamente `F5` como evidencia final.

## GitHub Actions

El workflow del repositorio compila en Windows y genera un artefacto de publicación como comprobación adicional. Esa automatización no sustituye la ejecución local que debe aparecer en el video.

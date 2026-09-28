# RegistroEstudiantesUIP

Aplicación de escritorio desarrollada en **C# con Windows Forms y .NET 8** para el taller práctico de **Compiladores** de la Universidad Interamericana de Panamá.

El proyecto implementa el desafío **WinForms: registro simple de estudiantes**, con validación de datos, visualización en `DataGridView` y publicación como ejecutable de Windows.

## Objetivo académico

Demostrar de forma controlada el ciclo:

```text
Código C# → Build → ensamblado .NET/IL → Runtime .NET → Publish → EXE Windows
```

La aplicación es deliberadamente pequeña: el foco está en comprender y evidenciar compilación, dependencias, ejecución y publicación.

## Funcionalidades

- Registro de ID, nombre y carrera.
- Validación de campos obligatorios.
- Validación de ID numérico y mayor que cero.
- Detección de IDs duplicados.
- Visualización de estudiantes en un `DataGridView`.
- Limpieza del formulario.
- Mensajes de estado para registros válidos e inválidos.
- Sin base de datos: los datos existen solo durante la ejecución.

## Arquitectura

Se utiliza una separación mínima por responsabilidades:

```text
MainForm (UI)
    │
    ▼
RegistroEstudiantesService (reglas y validaciones)
    │
    ▼
Estudiante (modelo)
```

La arquitectura evita mezclar las reglas de validación con el código visual de WinForms, pero mantiene el proyecto sencillo para la demostración académica.

## Estructura

```text
RegistroEstudiantesUIP/
├── .github/
│   └── workflows/
│       └── build.yml
├── docs/
│   ├── ARCHITECTURE.md
│   ├── EVIDENCIA_VIDEO.md
│   ├── PRUEBAS.md
│   └── PUBLICACION.md
├── src/
│   └── RegistroEstudiantesUIP/
│       ├── Models/
│       │   ├── Estudiante.cs
│       │   └── ResultadoRegistro.cs
│       ├── Services/
│       │   └── RegistroEstudiantesService.cs
│       ├── MainForm.cs
│       ├── MainForm.Designer.cs
│       ├── Program.cs
│       └── RegistroEstudiantesUIP.csproj
├── .gitignore
├── RegistroEstudiantesUIP.sln
└── README.md
```

## Requisitos

- Windows 10/11.
- Visual Studio 2022 o posterior.
- .NET 8 SDK.
- Workload **Desarrollo de escritorio de .NET**.

## Ejecutar

1. Abrir `RegistroEstudiantesUIP.sln`.
2. Restaurar dependencias si Visual Studio lo solicita.
3. Ejecutar con `F5`.

## Compilar

```bash
dotnet build RegistroEstudiantesUIP.sln -c Release
```

## Publicar para Windows x64

```bash
dotnet publish src/RegistroEstudiantesUIP/RegistroEstudiantesUIP.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

La evidencia final debe ejecutar el `.exe` desde la carpeta publicada, no únicamente desde Visual Studio.

## Estado

- [x] Arquitectura base definida.
- [x] Interfaz WinForms.
- [x] Registro y validaciones.
- [x] Documentación técnica.
- [x] Build automatizado en GitHub Actions.
- [ ] Validación final en Visual Studio.
- [ ] Publicación local `win-x64`.
- [ ] Grabación del video.
- [ ] Presentación final.

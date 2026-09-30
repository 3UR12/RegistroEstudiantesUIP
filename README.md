# RegistroEstudiantesUIP

Aplicación de escritorio para registrar estudiantes durante una sesión local. Desarrollada en **C#**, **Windows Forms** y **.NET 8** para el taller práctico de Compiladores de la Universidad Interamericana de Panamá.

![C#](https://img.shields.io/badge/C%23-.NET%208-512BD4?logo=dotnet&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-win--x64-0078D4?logo=windows11&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?logo=visualstudio&logoColor=white)

**Autor:** Euris J. Rodríguez V.  
**Asignatura:** Compiladores  
**Versión:** v1.0.0

## Funciones

| Función | Comportamiento |
|---|---|
| Registro | ID, nombre y carrera |
| Validación | Campos obligatorios, ID numérico y nombre mínimo |
| Duplicados | Impide registrar dos veces el mismo ID |
| Visualización | Registros mostrados en un DataGridView |
| Limpieza | Restablece el formulario |
| Contador | Muestra la cantidad de registros de la sesión |

> Los datos se mantienen en memoria. Al cerrar la aplicación, los registros se eliminan.

## Tecnología

- C# / Windows Forms
- .NET 8
- Visual Studio 2022
- Windows x64

## Estructura

```text
RegistroEstudiantesUIP/
├── src/RegistroEstudiantesUIP/
│   ├── Models/
│   ├── Services/
│   ├── Properties/PublishProfiles/
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   └── Program.cs
├── docs/
├── RegistroEstudiantesUIP.sln
└── README.txt
```

La interfaz se concentra en `MainForm`; las validaciones y el registro en memoria están en `RegistroEstudiantesService`; los datos se representan mediante `Estudiante` y `ResultadoRegistro`.

## Ejecutar el proyecto

Requisitos:

- Visual Studio 2022
- Carga de trabajo **Desarrollo de escritorio de .NET**
- .NET 8 SDK

```powershell
git clone https://github.com/3UR12/RegistroEstudiantesUIP.git
cd RegistroEstudiantesUIP
```

Abrir `RegistroEstudiantesUIP.sln` y ejecutar con **F5**.

## Compilar

```powershell
dotnet build RegistroEstudiantesUIP.sln -c Release
```

## Publicar para Windows x64

```powershell
dotnet publish src/RegistroEstudiantesUIP/RegistroEstudiantesUIP.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishTrimmed=false -p:PublishReadyToRun=false
```

Configuración del perfil `FolderProfile.pubxml`:

| Opción | Valor |
|---|---|
| Configuración | Release |
| Framework | net8.0-windows |
| Runtime | win-x64 |
| Implementación | Self-contained |
| Archivo único | Sí |
| Trim | No |
| ReadyToRun | No |

## Entrega

La versión final está disponible en:

**[RegistroEstudiantesUIP v1.0.0](https://github.com/3UR12/RegistroEstudiantesUIP/releases/tag/v1.0.0)**

La Release contiene el video de evidencia, el ejecutable de Windows y la presentación final.

## Documentación

- [Arquitectura](docs/ARCHITECTURE.md)
- [Instalación de Visual Studio](docs/INSTALACION_VISUAL_STUDIO_2022.md)
- [Publicación](docs/PUBLICACION.md)
- [Pruebas](docs/PRUEBAS.md)
- [Distribución](docs/DISTRIBUCION_Y_PROTECCION.md)

# RegistroEstudiantesUIP

Aplicación de escritorio para gestionar registros de estudiantes durante una sesión local. Desarrollada en **C#**, **Windows Forms** y **.NET 8** para el taller práctico de Compiladores de la Universidad Interamericana de Panamá.

![C#](https://img.shields.io/badge/C%23-.NET%208-512BD4?logo=dotnet&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-win--x64-0078D4?logo=windows11&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?logo=visualstudio&logoColor=white)

**Integrantes:** Euris J. Rodríguez V. · Daniela Insturaín · Aaron Fechrenback  
**Asignatura:** Compiladores

## Funciones

| Función | Comportamiento |
|---|---|
| Crear | Registra ID, nombre y carrera |
| Consultar | Muestra los registros en un DataGridView |
| Actualizar | Permite editar el registro seleccionado |
| Eliminar | Elimina el registro seleccionado con confirmación |
| Validación | Verifica campos obligatorios, ID, longitud y caracteres del nombre |
| Duplicados | Impide registrar IDs repetidos |
| Limpieza | Restablece el formulario sin borrar la lista |
| Contador | Muestra la cantidad de registros de la sesión |

> Los datos se mantienen únicamente en memoria. Al cerrar la aplicación, los registros se eliminan.

## Privacidad y seguridad

- No se guardan registros en archivos, base de datos ni servicios externos.
- No se realizan conexiones de red para almacenar información de estudiantes.
- La interfaz indica que deben utilizarse datos de práctica y evitar información personal real.
- La eliminación de registros solicita confirmación.
- Las entradas se validan antes de crear o actualizar un registro.
- No se incluyen contraseñas, tokens ni credenciales en el proyecto.

El proyecto es académico. No está diseñado para almacenar expedientes reales ni información sensible.

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

La interfaz se concentra en `MainForm`; las validaciones y operaciones CRUD en memoria están en `RegistroEstudiantesService`; los datos se representan mediante `Estudiante` y `ResultadoRegistro`.

## Uso

1. Complete ID, nombre y carrera y seleccione **Agregar**.
2. Seleccione una fila para cargarla en el formulario.
3. Use **Actualizar** para guardar cambios o **Eliminar** para quitar el registro.
4. Use **Limpiar** para cancelar la selección y preparar un registro nuevo.

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

La release `v1.0.0` corresponde a la entrega inicial del proyecto. La rama `main` incorpora las mejoras posteriores del CRUD y las medidas de privacidad descritas en este README.

**[RegistroEstudiantesUIP v1.0.0](https://github.com/3UR12/RegistroEstudiantesUIP/releases/tag/v1.0.0)**

## Documentación

- [Arquitectura](docs/ARCHITECTURE.md)
- [Instalación de Visual Studio](docs/INSTALACION_VISUAL_STUDIO_2022.md)
- [Publicación](docs/PUBLICACION.md)
- [Pruebas](docs/PRUEBAS.md)
- [Distribución y protección](docs/DISTRIBUCION_Y_PROTECCION.md)

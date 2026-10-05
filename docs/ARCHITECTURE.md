# Arquitectura

RegistroEstudiantesUIP utiliza una estructura simple para separar interfaz, lógica y datos.

## Componentes

| Componente | Responsabilidad |
|---|---|
| `MainForm.cs` | Eventos, selección de filas y actualización de la interfaz |
| `MainForm.Designer.cs` | Definición visual del formulario y controles CRUD |
| `RegistroEstudiantesService.cs` | Validaciones, duplicados y operaciones CRUD en memoria |
| `Estudiante.cs` | Modelo del estudiante |
| `ResultadoRegistro.cs` | Resultado de las operaciones sobre registros |

## Flujo

```text
Usuario
  │
  ▼
MainForm
  │  ID / nombre / carrera
  ▼
RegistroEstudiantesService
  │
  ├─ valida datos
  ├─ comprueba duplicados
  ├─ crea registros
  ├─ actualiza registros
  └─ elimina registros
  │
  ▼
ResultadoRegistro
  │
  ▼
MainForm
  ├─ mensaje de estado
  ├─ DataGridView
  └─ contador
```

## Privacidad y persistencia

No se utiliza base de datos, almacenamiento en archivos ni servicios externos. Los registros existen únicamente durante la sesión de la aplicación y se eliminan al cerrarla.

Las operaciones de eliminación requieren confirmación y las entradas se validan antes de crear o actualizar un registro.

## Destino

```text
Framework: net8.0-windows
Runtime: win-x64
Modo: self-contained
Archivo único: sí
```

El perfil de publicación está en:

```text
src/RegistroEstudiantesUIP/Properties/PublishProfiles/FolderProfile.pubxml
```

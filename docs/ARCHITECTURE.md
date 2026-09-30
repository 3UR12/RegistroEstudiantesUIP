# Arquitectura

RegistroEstudiantesUIP utiliza una estructura simple para separar interfaz, lógica y datos.

## Componentes

| Componente | Responsabilidad |
|---|---|
| `MainForm.cs` | Eventos, actualización de la interfaz y DataGridView |
| `MainForm.Designer.cs` | Definición visual del formulario |
| `RegistroEstudiantesService.cs` | Validaciones, duplicados y colección en memoria |
| `Estudiante.cs` | Modelo del estudiante |
| `ResultadoRegistro.cs` | Resultado de una operación de registro |

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
  └─ registra en memoria
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

## Persistencia

No se utiliza base de datos ni almacenamiento en archivos. Los registros existen únicamente durante la sesión de la aplicación.

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

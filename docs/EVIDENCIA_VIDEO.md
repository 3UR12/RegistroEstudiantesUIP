# Evidencia para el video

Duración requerida: **1 a 6 minutos**.

## 1. Presentación — 15 a 30 s

- Nombre del proyecto: Registro de estudiantes.
- Desafío: WinForms, registro simple.
- Objetivo: registrar y visualizar estudiantes con validaciones básicas.

## 2. Código y diseño — 30 a 60 s

Mostrar brevemente:

- `MainForm.cs`.
- `RegistroEstudiantesService.cs`.
- `Estudiante.cs`.
- El diseñador de WinForms y el `DataGridView`.

Explicar que la interfaz captura los datos y el servicio aplica las reglas de validación.

## 3. Compilación — 30 a 60 s

- Seleccionar `Release`.
- Ejecutar **Build > Build Solution**.
- Mostrar la compilación exitosa.

## 4. Publicación — 30 a 60 s

- Mostrar **Publish > Folder**.
- Mostrar el destino `win-x64`.
- Mostrar la carpeta de salida y `RegistroEstudiantesUIP.exe`.

## 5. Ejecución — 45 a 120 s

Ejecutar el `.exe` directamente y demostrar:

1. Registro válido.
2. Registro inválido con un campo vacío.
3. Registro duplicado si el tiempo lo permite.

## 6. Cierre — 15 a 30 s

Explicar brevemente:

- El código fuente está en archivos `.cs`.
- El compilador genera un ensamblado .NET con IL y metadatos.
- El runtime .NET ejecuta la aplicación.
- La publicación prepara el host `.exe` y sus dependencias para Windows.

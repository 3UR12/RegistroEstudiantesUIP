# Pruebas

## Casos funcionales

| Caso | Entrada / acción | Resultado esperado |
|---|---|---|
| Crear registro válido | 1001 / Ana Pérez / Ingeniería en Sistemas Computacionales | Registro agregado y contador actualizado |
| Campo vacío | Nombre vacío | Registro rechazado |
| ID no numérico | abc | Registro rechazado |
| ID cero o negativo | 0 / -1 | Registro rechazado |
| Nombre corto | Ab | Registro rechazado |
| Nombre con caracteres no permitidos | Ana123 | Registro rechazado |
| ID duplicado | 1001 registrado dos veces | Segundo registro rechazado |
| Consultar | Revisar la tabla | Los registros creados aparecen en el DataGridView |
| Seleccionar | Clic en una fila | Los datos se cargan en el formulario |
| Actualizar | Modificar nombre o carrera y pulsar Actualizar | La fila seleccionada refleja los cambios |
| Eliminar | Seleccionar una fila y confirmar Eliminar | El registro desaparece y el contador se actualiza |
| Cancelar eliminación | Seleccionar No en la confirmación | El registro permanece sin cambios |
| Limpiar | Datos escritos o fila seleccionada | Campos y selección se restablecen sin borrar registros |
| Privacidad de sesión | Cerrar y volver a abrir la aplicación | No se conservan registros de la sesión anterior |

## Privacidad y seguridad

- Los datos permanecen en memoria durante la ejecución.
- No se crean archivos de datos ni se utiliza una base de datos.
- No se envían registros a servicios externos.
- La eliminación requiere confirmación.
- Las entradas se validan antes de crear o actualizar registros.
- Para pruebas se recomienda utilizar información ficticia.

## Compilación

```text
Release | Any CPU
```

Resultado esperado: compilación completada sin errores.

## Publicación

```text
Framework: net8.0-windows
Runtime: win-x64
Modo: self-contained
Archivo único: sí
Trim: no
ReadyToRun: no
```

El ejecutable publicado debe abrir correctamente fuera de Visual Studio.

## Referencia de entrega

La release `v1.0.0` corresponde a la entrega inicial. Las mejoras CRUD y de privacidad se mantienen en la rama principal después de su integración.

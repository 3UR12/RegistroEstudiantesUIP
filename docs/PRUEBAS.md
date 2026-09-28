# Plan de pruebas

## Casos funcionales

| Caso | Entrada | Resultado esperado |
|---|---|---|
| Registro válido | 1001 / Ana Pérez / Ingeniería en Sistemas Computacionales | Se agrega una fila al DataGridView |
| Campo vacío | Nombre vacío | Se rechaza el registro |
| ID no numérico | abc | Se rechaza el registro |
| ID cero o negativo | 0 o -1 | Se rechaza el registro |
| Nombre corto | Ab | Se rechaza el registro |
| ID duplicado | Registrar 1001 dos veces | El segundo registro se rechaza |
| Limpiar | Datos escritos + botón Limpiar | Los campos vuelven a su estado inicial |

## Prueba de compilación

1. Seleccionar `Release`.
2. Ejecutar **Build > Build Solution**.
3. Confirmar que no existan errores de compilación.

## Prueba de publicación

1. Publicar para `win-x64`.
2. Cerrar o minimizar Visual Studio.
3. Ejecutar `RegistroEstudiantesUIP.exe` desde la carpeta publicada.
4. Repetir un registro válido y uno inválido.

## Criterio de aceptación

La versión final se considera lista cuando:

- compila en Release sin errores;
- el registro válido aparece en la tabla;
- los casos inválidos son rechazados;
- el ejecutable publicado funciona fuera de Visual Studio.

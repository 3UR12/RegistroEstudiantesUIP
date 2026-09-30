# Plan de pruebas

## Casos funcionales

| Caso | Entrada | Resultado esperado |
|---|---|---|
| Registro válido | 1001 / Ana Pérez / Ingeniería en Sistemas Computacionales | Se agrega una fila al DataGridView y aumenta el contador |
| Campo vacío | Nombre vacío | Se rechaza el registro |
| ID no numérico | abc | Se rechaza el registro |
| ID cero o negativo | 0 o -1 | Se rechaza el registro |
| Nombre corto | Ab | Se rechaza el registro |
| ID duplicado | Registrar 1001 dos veces | El segundo registro se rechaza |
| Limpiar | Datos escritos + botón Limpiar | Los campos vuelven a su estado inicial |

## Compilación

Configuración:

~~~text
Release | Any CPU
~~~

Procedimiento:

1. Ejecutar **Compilar > Compilar solución**.
2. Confirmar que la salida no reporte errores.

## Publicación

Configuración:

~~~text
net8.0-windows
win-x64
Independiente
Archivo único
Trim desactivado
ReadyToRun desactivado
~~~

Procedimiento:

1. Publicar con FolderProfile.
2. Cerrar Visual Studio.
3. Ejecutar RegistroEstudiantesUIP.exe.
4. Repetir un caso válido y al menos un caso inválido.

## Validación realizada el 29-09-2026

La versión actual fue verificada en Windows con el diseño final.

Resultados confirmados:

- registro válido;
- actualización del contador de registros;
- validación de campo vacío;
- rechazo de ID duplicado;
- botón Limpiar;
- compilación Release sin errores;
- publicación win-x64 con FolderProfile;
- ejecución del .exe fuera de Visual Studio.

Cualquier modificación posterior al código requiere repetir la compilación, publicación y validación del ejecutable.

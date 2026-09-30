# Pruebas

## Casos funcionales

| Caso | Entrada | Resultado |
|---|---|---|
| Registro válido | 1001 / Ana Pérez / Ingeniería en Sistemas Computacionales | Registro agregado y contador actualizado |
| Campo vacío | Nombre vacío | Registro rechazado |
| ID no numérico | abc | Registro rechazado |
| ID cero o negativo | 0 / -1 | Registro rechazado |
| Nombre corto | Ab | Registro rechazado |
| ID duplicado | 1001 registrado dos veces | Segundo registro rechazado |
| Limpiar | Datos escritos | Campos restablecidos |

## Compilación

```text
Release | Any CPU
```

Resultado: compilación completada sin errores.

## Publicación

```text
Framework: net8.0-windows
Runtime: win-x64
Modo: self-contained
Archivo único: sí
Trim: no
ReadyToRun: no
```

Resultado: `RegistroEstudiantesUIP.exe` generado y ejecutado fuera de Visual Studio.

## Versión comprobada

`v1.0.0` — 29 de septiembre de 2026.

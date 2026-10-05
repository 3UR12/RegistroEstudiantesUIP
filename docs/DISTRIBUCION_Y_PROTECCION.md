# Distribución y protección

## Código fuente

El repositorio es público y contiene únicamente el código fuente, la configuración del proyecto y documentación académica. No deben incluirse contraseñas, tokens, credenciales ni datos personales reales.

Los archivos generados por compilación no se guardan en el historial del repositorio. `.gitignore` excluye `bin/`, `obj/`, `publish/`, símbolos de depuración y archivos temporales.

## Privacidad de los registros

Los registros creados desde la aplicación se mantienen únicamente en memoria durante la sesión.

- No se guardan en archivos locales.
- No se almacenan en una base de datos.
- No se envían por red.
- Se eliminan al cerrar la aplicación.
- La interfaz recomienda utilizar datos ficticios para las pruebas.

El proyecto no debe utilizarse para almacenar expedientes reales ni información sensible.

## Validaciones y acciones destructivas

Antes de crear o actualizar un registro se validan los campos obligatorios, el ID y el nombre. Los IDs duplicados se rechazan. La eliminación de un registro requiere confirmación para reducir borrados accidentales.

## Ejecutable

La versión distribuida utiliza:

```text
Release
Optimize = true
DebugType = none
DebugSymbols = false
PublishSingleFile = true
SelfContained = true
Runtime = win-x64
```

El ejecutable se publica como archivo único y sin símbolos de depuración.

## Alcance

Una aplicación .NET puede ser analizada con herramientas de ingeniería inversa. La configuración Release reduce información de depuración, pero no convierte el binario en un formato imposible de descompilar.

La entrega no utiliza ofuscación y no depende de ocultar el código para proteger datos, ya que la aplicación no conserva información de estudiantes después de cerrarse.

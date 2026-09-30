# Distribución

## Código fuente

El repositorio se mantiene privado. El acceso al código fuente depende de los permisos asignados en GitHub.

Los archivos generados por compilación no se guardan en el historial del repositorio. `.gitignore` excluye `bin/`, `obj/`, `publish/`, símbolos de depuración y archivos temporales.

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

Una aplicación .NET puede ser analizada con herramientas de ingeniería inversa. La configuración de Release reduce información de depuración, pero no convierte el binario en un formato imposible de descompilar.

La entrega no utiliza obfuscación.

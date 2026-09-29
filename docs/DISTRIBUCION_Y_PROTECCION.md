# Distribución y protección del código

## Repositorio

La visibilidad del repositorio determina si otras personas pueden consultar el código fuente.

Si el repositorio es público, los archivos .cs, el proyecto y la documentación son visibles. Ninguna configuración de compilación puede ocultar un código que ya está publicado en GitHub.

Para restringir el acceso:

~~~text
GitHub
> Settings
> General
> Danger Zone
> Change repository visibility
> Private
~~~

Después pueden agregarse colaboradores autorizados desde la configuración del repositorio.

## Ejecutable .NET

El proyecto se compila a .NET. Una aplicación .NET distribuida puede ser analizada o descompilada con herramientas especializadas. No existe una opción de Visual Studio que convierta un ejecutable .NET en código imposible de recuperar.

La configuración del proyecto reduce información innecesaria de depuración en la distribución:

~~~text
Release
Optimize = true
DebugType = none
DebugSymbols = false
PublishSingleFile = true
SelfContained = true
Runtime = win-x64
~~~

Esto elimina símbolos de depuración y concentra la publicación, pero no debe considerarse una protección absoluta contra descompilación.

## Archivos excluidos del repositorio

El archivo .gitignore excluye:

- .vs/;
- bin/;
- obj/;
- carpetas publish/;
- archivos .pdb;
- archivos temporales y logs.

Los binarios de compilación no forman parte del historial de código.

## Obfuscación

La obfuscación puede dificultar la lectura de código descompilado, pero introduce una etapa adicional en el proceso de publicación y debe probarse contra WinForms antes de utilizarse en la entrega.

No se incorpora un obfuscador al flujo principal mientras el proyecto académico esté en validación final. La medida efectiva para impedir que terceros consulten el código original en GitHub es mantener el repositorio privado.

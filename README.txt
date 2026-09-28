REGISTRO DE ESTUDIANTES - COMPILADORES UIP
===========================================

Desafío:
WinForms - Registro simple de estudiantes.

Tecnologías:
- C#
- Windows Forms
- .NET 8
- Visual Studio 2022 o posterior
- Windows x64

Cómo ejecutar desde Visual Studio:
1. Abrir RegistroEstudiantesUIP.sln.
2. Verificar el workload "Desarrollo de escritorio de .NET".
3. Compilar con Build > Build Solution.
4. Ejecutar con F5.

Publicación recomendada:
1. Cambiar la configuración a Release.
2. Clic derecho sobre el proyecto > Publish / Publicar.
3. Seleccionar Folder / Carpeta.
4. Runtime: win-x64.
5. Deployment mode: Self-contained.
6. Activar Produce single file cuando esté disponible.
7. Publicar.
8. Ejecutar RegistroEstudiantesUIP.exe desde la carpeta de publicación.

Comando equivalente:
dotnet publish src/RegistroEstudiantesUIP/RegistroEstudiantesUIP.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true

Importante:
La aplicación no utiliza base de datos. Los registros existen solo durante la ejecución.

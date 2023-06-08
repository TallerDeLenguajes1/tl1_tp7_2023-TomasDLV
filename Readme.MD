El parámetro `--output` en el comando `dotnet new console --output .` se utiliza para especificar la ruta de salida o directorio donde se creará el nuevo proyecto de consola. 

En este caso, el punto (`.`) como argumento para `--output` indica que el proyecto se creará en el directorio actual. Esto significa que el nuevo proyecto de consola se generará en la carpeta donde se ejecutó el comando. Por ejemplo, si estás en la carpeta `/Users/usuario/proyectos/`, al ejecutar `dotnet new console --output .`, se creará un nuevo proyecto de consola en la ubicación `/Users/usuario/proyectos/NombreProyecto`.

Si no se especifica el parámetro `--output`, el comando `dotnet new console` creará el nuevo proyecto en un directorio con el mismo nombre del proyecto en el directorio actual.

Llamar al comando con `--output .` es útil cuando deseas crear un nuevo proyecto de consola en el directorio actual sin crear una carpeta adicional para el proyecto. Esto puede ser conveniente si prefieres mantener todos tus proyectos en un solo directorio o si deseas evitar la creación de una carpeta adicional para un proyecto de consola simple.

Es importante tener en cuenta que al utilizar `--output .`, si ya existe un archivo o carpeta con el nombre del proyecto en el directorio actual, el comando puede sobrescribir o causar conflictos con los archivos existentes. Por lo tanto, se recomienda asegurarse de que no haya conflictos antes de utilizar este enfoque.
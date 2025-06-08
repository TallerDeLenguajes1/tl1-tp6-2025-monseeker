[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)


### ¿`string` es un tipo por valor o un tipo por referencia?
string es un tipo por referencia en C#. Sin embargo, se comporta de forma inmutable, lo que significa que cada vez que se modifica una cadena, se crea una nueva instancia en memoria.
Aunque es por referencia, no se puede modificar directamente su contenido una vez creada.


### ¿Qué secuencias de escape tiene el tipo `string`? 

`\n`   Salto de línea        
`\r`   Retorno de carro        
`\t`   Tabulación (tab)        
`\\`   Barra invertida (`\`)   
`\'`   Comilla simple          
`\"`   Comilla doble           
`\0`   Null character (fin de cadena)

### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto? 
- `@` **(verbatim string literal):** Permite escribir la cadena literalmente, sin interpretar las secuencias de escape. Es útil para escribir rutas de archivos o cadenas con muchas comillas.
```csharp
string ruta = @"C:\Usuarios\Alumno\Documentos";
```

- `$` **(interpolated string):** Permite incluir expresiones o variables dentro de la cadena, usando {}.
```csharp
string nombre = "Ana";
string saludo = $"Hola, {nombre}!";
```

- `$@` **o** `@$` **juntos:** Se pueden usar ambos para interpolar variables y a la vez evitar secuencias de escape.
```csharp
string carpeta = "MisDocumentos";
string ruta = $@"C:\Usuarios\Alumno\{carpeta}";
```

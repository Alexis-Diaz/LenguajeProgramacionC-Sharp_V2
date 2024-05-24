//INSTRUCCIONES DE NIVEL SUPERIOR (Top-Level Statements)

//Antes de la llegada de .NET 5 con C#9, era necesario que en los programas de consola se cumpliera
//con cierta formalidad para crear un programa funcional.

//Por ejemplo, en la introduccion vimos que inicialmente Visual Studio nos crea un proyecto que consta
//solo de dos lineas de codigo. Pues bien, antes esto no era asi y se requeria que para imprimir un
//simple mensaje por consola se cumpliera con toda una ceremonia inicial que tenia la siguiente
//estructura.

namespace TopLevelStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

//Explicación del ejemplo anterior

//Linea 11: Un namespace o espacion de nombre son bloques que sirven para organizar el código. Pueden ser
//contenedores de clases y otros namespace.

//Linea 12: Las llaves de apertura y cierre {} indican el inicio y final de un bloque de código. Aqui se 
//indica que inicia el namespace "TopLevelStatements".

//Linea 13: Las clases (class) son contenedores de propiedades, campos y metodos. Las clases son bloques
//de codigo que le dan funcionalidad a un programa. Todas las lineas de codigo que seran ejecutadas se
//escriben dentro de una clase. Por ejemplo observa que la instruccion "Console.WriteLine("Hello, World!");"
//va dentro de la clase Program

//Linea 14: Indica el inicio del bloque que corresponde a la clase Program.

//Linea 15: Es la firma del metodo Main. Este metodo es especial y todos los programa deben tener un solo
//metodo Main. No es necesario que por ahora entiendes cada una de sus partes, pero es bueno que sepas que
//este metodo existe.

//Linea 16: Indica el inicio del cuerpo del metodo Main.

//Linea 17: Console es una clase del espacio de nombres System, que tiene un metodo WriteLine() que se
//utiliza para generar/imprimir texto. En nuestro ejemplo, mostrará "Hello, World!".

//Linea 18, 19 , 20: Esta llaves marcan el cierre del metodo, clase y espacio de nombres respectivamente.

//Como indicamos anteriormente, apartir de NET 5 ya no es necesario escribir todas esa lineas de codigo
//gracias a las instrucciones de nivel superior que nos permiten escribir codigo directamente en el archivo
//Program.cs y facilita escribir programas sencillos para utilidades pequeñas a la vez que facilitan a los
//nuevos programadores de C# empezar a aprender y escribir código. Claro, al crear un nuevo proyecto de 
//consola hay una casilla que permite inhabilitar este compartamiento si lo que prefieres es construir
//programas de consola con la antigua forma de hacerlo.

//Tambies debes tomar en cuenta que existen ciertas reglas que indican lo que podemos y no hacer con las
//instrucciones de nivel superior. Durante la marcha iremos aprendiente estas reglas.

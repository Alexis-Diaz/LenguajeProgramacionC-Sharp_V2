using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace _05_Variables
{
    //Un parámetro declarado sin un modificador in, out o ref es un parámetro de valor.
    //Un parámetro de valor surge tras la invocación del miembro de función (método,
    //constructor de instancia) o de la función anónima a la que pertenece el parámetro,
    //y se inicializa con el valor del argumento dado en la invocación.Un parámetro de
    //valor normalmente deja de existir cuando se completa la ejecución del cuerpo de la
    //función.Sin embargo, si el parámetro por valor es capturado por una función anónima
    //su vida útil se extiende al menos hasta que el delegado o árbol de expresión creado
    //a partir de esa función anónima sea elegible para la recolección de basura.
    //A efectos de la comprobación de la asignación definitiva, se considera inicialmente
    //asignado un parámetro de valor.
    internal class ParametroDeValor
    {
        public void ImprimirParametroDeValor(string parametroPorValor)
        {
            Console.WriteLine(parametroPorValor);
        }
    }
}

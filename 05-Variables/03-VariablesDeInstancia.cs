using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _05_Variables
{
    //VARIABLES DE INSTANCIA
    //Una variable de instancia de una clase surge cuando se crea una nueva instancia de esa
    //clase y deja de existir cuando no hay referencias a esa instancia y el finalizador de
    //la instancia(un método especial que se ejecuta antes de que el objeto sea destruido)
    //se ha ejecutado.

    //El valor inicial de una variable de instancia de una clase es el valor predeterminado
    //del tipo de variable. Por ejemplo:
    //  Los números(como int, double) se inicializan en 0 o 0.0.
    //  Los objetos(como String, List) se inicializan en null.
    //  Los valores booleanos se inicializan en false.

    //Para la verificación de asignación definitiva (que es una forma de asegurarse de que una
    //variable tiene un valor antes de ser usada), una variable de instancia se considera que
    //ya tiene un valor asignado desde el inicio.
    internal class VariablesDeInstancia
    {
        public string variableDeInstancia;

        public VariablesDeInstancia()
        {
            Console.WriteLine(variableDeInstancia ?? "null");
            variableDeInstancia = "nuevo valor asignado al campo de instancia";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Variables
{
    //Un campo declarado con el modificador static es una variable estática. Una variable
    //estática surge antes de la ejecución del constructor static (si existe) y deja de
    //existir cuando la aplicación termina o se apaga.

    //En términos técnicos, una variable estática se considera como si ya tuviera un valor
    //asignado desde el inicio (asignacion definitiva). El valor inicial de una variable
    //estática es el valor predeterminado del tipo de variable, esta caracteristica hace
    //que no nos preocupemos si no inicializamos la variable ya que el compilador le
    //asignara el valor que el tipo tiene por defecto. (Mas adelante se aborda los tipos de
    //datos y sus valores por defectos). Sin embargo, como parte de las buenas practicas
    //es recomendable que le asignemos un valor a las variable estaticas.

    //Las campos estaticos (o variables estaticas) pertenecen a la clase y no a una ins-
    //tancia de la clase. Ejemplo:
    internal class VariablesEstaticas
    {
        //Campo o variable estatica
        public static string campoEstatico;

        //Constructor estatico
        static VariablesEstaticas()
        {
            //Antes de que se ejecute este constructor el campo "campoEstatico" ya existe
            //y su valor por defecto es null ya que es de tipo string.
            Console.WriteLine(campoEstatico ?? "null");

            //Al pasar el compilador por este constructor el campo toma el nuevo valor 
            //asignado, por lo que deja de ser null
            campoEstatico = "nuevo valor asignado al campo estatico";
        }
    }
}

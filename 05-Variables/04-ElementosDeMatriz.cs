using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Variables
{
    // ELEMENTO DE MATRIZ
    //Los elementos de una matriz surgen cuando se crea una instancia de matriz y dejan de
    //existir cuando no hay referencias a esa instancia de matriz.
    //El valor inicial de cada uno de los elementos de una matriz es el valor predeterminado
    //del tipo de elementos de la matriz.
    //A efectos de comprobar la asignación definitiva, un elemento de la matriz se considera
    //inicialmente asignado.
    internal class ElementosDeMatriz
    {
        public void ImprimirMatriz(string[] elementoDeMatriz)
        {
            foreach(string item in elementoDeMatriz)
            {
                Console.WriteLine(item);
            }
        }
    }
}

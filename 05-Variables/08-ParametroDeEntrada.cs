using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace _05_Variables
{
    internal class ParametroDeEntrada
    {
        //PARAMETROS IN
        //la palabra clave in se utiliza para definir parámetros que se pasan por referencia pero
        //que son de solo lectura dentro del método al que se pasan.Esto significa que el método
        //puede leer el valor del parámetro, pero no puede modificarlo.La principal ventaja de los
        //parámetros in es que permiten evitar la copia de grandes estructuras de datos, lo que
        //puede mejorar el rendimiento en ciertos escenarios.

        //***Características de los parámetros in***
        //Pasaje por referencia de solo lectura: Los parámetros in permiten que los datos sean
        //pasados por referencia sin permitir su modificación dentro del método.Esto garantiza
        //que el valor original no será alterado.

        //Mejora de rendimiento: Para estructuras de datos grandes, pasar por referencia puede
        //ser más eficiente que pasar por valor, ya que se evita la copia completa de los datos.

        //Inmutabilidad dentro del método: Aunque el parámetro se pasa por referencia, dentro
        //del método, el parámetro es tratado como de solo lectura.

        public void PruebaConParametrosDeEntrada()
        {
            int[] Edades = {16, 14, 54, 23, 12 };
            HacerLecturaDeParametroDeEntrada(in Edades);

        }

        void HacerLecturaDeParametroDeEntrada(in int[] edades)
        {
            //edades no se puede modificar dentro del metodo.
            Console.WriteLine("Haciendo lectura de la variable dentro del metodo:");
            foreach(int edad in edades)
            {
                Console.Write(edad + " ");
            }

        }

    }
}

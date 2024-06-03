using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Variables
{
    internal class ParametroPorReferencia
    {
        //PARAMETROS POR REFERENCIA
        //Los parametros pasados por referencia sufren cambios en todos los lugares desde donde se llamen,
        //ya que el metodo interactura con la variable original y no solo con su valor.

        //Inicialización previa requerida: El parámetro pasado con ref debe estar inicializado antes de ser
        //pasado al método.Es decir, debes asignarle un valor antes de llamar al método.

        //Persistencia de valores: El valor del parámetro puede ser leído y modificado tanto dentro como fuera
        //del método.Los cambios realizados en el parámetro dentro del método se reflejan fuera de él.
        public void PruebaConParametrosPorReferencia()
        {
            string AnimalA = "Caballo";//==> Si no asignamos un valor da error en tiempo de compilacion.
            Console.WriteLine("Valor inicial de la variable: " + AnimalA);
            CambiarValorParametroPorReferencia(ref AnimalA);
            Console.WriteLine("Valor final de la variable: " + AnimalA);
            Console.WriteLine();

            string AnimalB = "Caballo";
            Console.WriteLine("Valor inicial de la variable: " + AnimalB);
            CambiarValorParametroPorValor(AnimalB);
            Console.WriteLine("Valor final de la variable: " + AnimalB);
        }

        void CambiarValorParametroPorReferencia(ref string parametroPorReferencia)
        {
            parametroPorReferencia += " Veloz";
            Console.WriteLine("Se cambia el valor de la variable dentro del metodo: " + parametroPorReferencia);
        }

        void CambiarValorParametroPorValor(string parametroPorValor)
        {
            parametroPorValor += " Veloz";
            Console.WriteLine("Se cambia el valor de la variable dentro del metodo: " + parametroPorValor);
        }
    }
}

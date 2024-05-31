using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Variables
{
    internal class Conceptualizacion
    {
        //GENERALIDADES DE LAS VARIABLES
        //Las variables representa ubicaciones de almacenamiento. Cada variable puede contener un valor
        //que esta definido por un tipo.
        //C# es un lenguaje de programacion fuertemente tipado y el compilador asegura que cada variable
        //contenga el tipo apropiado.

        //Las variables pueden ser asignadas con un valor al momento de crearlas o ser iniciadas mas
        //adelante. Una variable es definitivamente asignada cuando al crearse se le asigna un valor ya
        //que de alli en adelante tiene un valor bien definido. Es por esa razon que el compilador 
        //mostrara un error si pretendemos usar una variable que no se considera definitivamente asig-
        //nada. 

        //CATEGORIAS DE LAS VARIABLES
        //C# define ocho categorias de variables:
        //1-Variables estaticas
        //2-Variables de instancia
        //3-Elementos de matriz
        //4-Parametros por valor
        //5-Parametros de entrada
        //6-Parametros de referencia
        //7-Parametros de salida
        //8-Variables locales

        //A continuacion se muestra cada una de las variables antes mencionadas:
        class CategoriaVariables
        {
            public static int variableEstatica;
            int variableDeInstancia;

            void Metodo(int[] elementoDeMatriz, int parametroPorValor, in int parametroDeEntrada, ref int parametroDeReferencia, out int parametroDeSalida)
            {
                int variableLocal = 1;
                parametroDeSalida = parametroPorValor + parametroDeReferencia++ + parametroDeEntrada;
            }
        }

        //Ahora que ya conocemos cada categoria de variables, veamos sus caracteristicas una por una.

        //NOTA: Cada categoria de variable lo estudiaremos en un archivo separado. La clase program la usaremos solo
        //para imprimir los valores de las diferentes categorias de variables.
    }
}

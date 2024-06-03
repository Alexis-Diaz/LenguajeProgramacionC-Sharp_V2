using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _05_Variables
{
    internal class ParametroDeSalida
    {
        //PARAMETROS DE SALIDA
        //Los parámetros out son una forma de pasar argumentos a un método para que el método
        //pueda devolver múltiples valores a través de esos parámetros.La palabra clave out
        //indica que un parámetro se pasará por referencia y que debe ser asignado un valor
        //dentro del método antes de que el método finalice.

        //Inicialización previa no requerida: El parámetro pasado con out no necesita estar
        //inicializado antes de ser pasado al método.En otras palabras, puedes pasar una
        //variable sin valor asignado.

        //Obligación de asignación: Dentro del método, se debe asignar un valor al parámetro
        //antes de que el método termine.Si no se asigna un valor, el compilador generará un error.

        //Propósito específico: out está diseñado específicamente para devolver datos desde
        //el método, por lo que se usa comúnmente en métodos que necesitan devolver múltiples valores.

        //Resumen de Diferencias con ref
        //Inicialización previa: ref requiere que el parámetro esté inicializado antes de
        //ser pasado; out no lo requiere.

        //Asignación obligatoria: En ref, la asignación dentro del método es opcional; en out,
        //es obligatoria. Propósito: ref se usa para modificar valores existentes; out se usa
        //para devolver valores nuevos desde el método.
        
        public void PruebaConParametrosDeSalida()
        {
            string param;//No es requerido inicializar la variable
            AsignarValorParametroDeSalida(out param);
            Console.WriteLine("Fuera del metodo");
            Console.WriteLine(param);
        }

        void AsignarValorParametroDeSalida(out string parametroDeSalida)
        {
            Console.WriteLine("Dentro del metodo");
            parametroDeSalida = "Parametro out: Valor asignado.";
            Console.WriteLine(parametroDeSalida);
        }
    }
}

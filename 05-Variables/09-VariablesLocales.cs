using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Variables
{
    internal class VariablesLocales
    {
        public void MetodoA()
        {
            string variableLocal = "Variable local del metodo MetodoA()";
            MetodoB();
            Console.WriteLine(variableLocal);
        }

        void MetodoB()
        {
            string variableLocal = "Variable local del metodo MetodoB()";
            Console.WriteLine(variableLocal);
        }
    }
}

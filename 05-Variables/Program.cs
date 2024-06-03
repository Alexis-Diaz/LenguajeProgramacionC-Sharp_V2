using _05_Variables;

//Impresion de variable estatica
Console.WriteLine("========Variables estaticas=======");
Console.WriteLine(VariablesEstaticas.campoEstatico);
Console.WriteLine();

//Impresion de variable estatica
Console.WriteLine("======Variables de instancia======");
VariablesDeInstancia vi = new();
Console.WriteLine(vi.variableDeInstancia);
Console.WriteLine();

//Impresion de elementos de matriz
Console.WriteLine("========Elementos de matriz=======");
ElementosDeMatriz em = new();
string[] elementosDeMatriz = { "elem1", "elem2", "elem3", "elem4" };
em.ImprimirMatriz(elementosDeMatriz);
Console.WriteLine();

//Impresion de parametro por valor
Console.WriteLine("========Parametro por valor=======");
ParametroDeValor pv = new();
pv.ImprimirParametroDeValor("Programacion");
Console.WriteLine();

//Impresion de parametro por referencia
Console.WriteLine("========Parametro por referencia=======");
ParametroPorReferencia pr = new();
pr.PruebaConParametrosPorReferencia();
Console.WriteLine();

//Impresion de parametro de salida
Console.WriteLine("========Parametro de salida=======");
ParametroDeSalida ps = new();
ps.PruebaConParametrosDeSalida();
Console.WriteLine();

//Impresion de parametro de entrada
Console.WriteLine("========Parametro de entrada=======");
ParametroDeEntrada pe = new();
pe.PruebaConParametrosDeEntrada();
Console.WriteLine();
Console.WriteLine();

//Impresion de variables locales
Console.WriteLine("========Variables locales=======");
VariablesLocales vl = new();
vl.MetodoA();
Console.WriteLine();
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
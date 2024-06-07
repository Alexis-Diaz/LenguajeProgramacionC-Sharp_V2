//CLASE MATH

//Para realizar operaciones matematicas podemos hacer uso de los operadores aritmeticos.
//Sin embargo existe una clase propia de .NET que nos facilita el trabajo de realizar
//muchas de estas tareas habituales, algunas de ellas hasta complejas de hacer por 
//cuenta propia.

//Ejemplo de uso de la clase math

//======================================================================================//
//VALOR ABSOLUTO
//Cada numero sea negativo o positivo tiene un valor absoluto, es decir la cantidad
//de espacios que tiene hasta el cero (0). El valor absoluto siempre se expresa en
//valores positivos.

Console.WriteLine(Math.Abs(-10));//10

//======================================================================================//
//ARCOSENO
//Devuelve el ángulo cuyo coseno es el número especificado.
//Parametro: Un número que representa un coseno, donde d debe ser mayor o igual a -1,
//pero menor o igual a 1.

//Para encontrar el ángulo cuyo coseno es 0.67, necesitamos usar la función inversa del coseno, conocida como arccoseno o 
//cos-1. El resultado se puede expresar en radianes o grados.
//El ángulo cuyo coseno es 0.67 es aproximadamente: 0.8365875393415376 radianes
Console.WriteLine(Math.Acos(0.67));//0.8365875393415376

//======================================================================================//
//SENO
Console.WriteLine(Math.Asin(0.8));

//======================================================================================//
//POTENCIA
Console.WriteLine(Math.Pow(3, 2));//3 X 3 = 9

//======================================================================================//
//RAIZ CUADRADA
Console.WriteLine(Math.Sqrt(9));//raiz cuadrada de 9 = 3

//======================================================================================//
//RAIZ CUBICA
Console.WriteLine(Math.Cbrt(27));//3

//======================================================================================//
//REDONDEO HACIA ARRIBA, REDONDEO HACIA ABAJO, REDONDEO NORMAL
decimal[] values = {
                      7.1m,  7.2m,  7.3m,  7.4m,  7.5m,  7.6m,  7.7m,  7.8m,  7.9m,
                      6.1m,  6.2m,  6.3m,  6.4m,  6.5m,  6.6m,  6.7m,  6.8m,  6.9m,
                     -4.1m, -4.2m, -4.3m, -4.4m, -4.5m, -4.6m, -4.7m, -4.8m, -4.9m,
                     -3.1m, -3.2m, -3.3m, -3.4m, -3.5m, -3.6m, -3.7m, -3.8m, -3.9m
                   };
Console.WriteLine("     Value   Ceiling     Floor     Round\n");
foreach (decimal value in values)
    //El primer numero indica el parametro que se imprimirá.
    //El segundo numero indica la anchura mínima del campo en el que se debe imprimir cada valor,
    //si el valor no llena el ancho minimo se rellenara con espacios a la izquierda.
    Console.WriteLine("{0,10}{1,10}{2,10}{3,10}", value, Math.Ceiling(value), Math.Floor(value), Math.Round(value));

//======================================================================================//
//OBTIENE EL MINIMO ENTRE DOS NUMEROS
Console.WriteLine(Math.Min(19001, 19002));

//======================================================================================//
//OBBTIENE EL MAXIMO ENTRE DOS NUMEROS
Console.WriteLine(Math.Max(19001, 19002));

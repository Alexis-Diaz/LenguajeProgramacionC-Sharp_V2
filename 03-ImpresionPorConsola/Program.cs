//TEMA:Impresion de valores por consola.

//Para realizar la impresion de valores por consola podemos utilizar el metodo WriteLine().
//Los valores que deseamos ver por consola van dentro de los parentesis.

//Imprimir por consola el siguiente texto: "Mi primer programa en C#". Observar que para
//imprimir un texto es necesario escribirlo entre comillas dobles.
Console.WriteLine("Mi primer programa en C#");

//El metodo WriteLine puedes llamarlo o invocarlo tantas veces desees.
Console.WriteLine("Linea de texto 1");
Console.WriteLine("Linea de texto 2");
Console.WriteLine("Linea de texto 3");

//Ademas de texto tambien puedes imprir valores numericos. Para imprimir numeros
//no es necesario usar las comillas dobles.
Console.WriteLine(7);
Console.WriteLine(15);
Console.WriteLine(38);

//Con el metodo WriteLine tambien puedes hacer calculos matematicos. Por ejemplo, indicarle
//que primero sume dos numeros y luego que imprima el resultado en consola.
//Aqui el resultado sera 23.
Console.WriteLine(9 + 14);

//DIFERENCIA ENTRE EL METODO WriteLine y Write
//A aparte del metodo WriteLine tambien existe el metodo Write que hace la misma funcion de 
//imprimir un valor por consola. La diferencia estriba en que WriteLine escribe la linea y
//luego agrega un salto de linea. Mientras que Write escribe todo en la misma linea.
Console.Write("Esta es una ");
Console.Write("sola oracion. ");
Console.Write("Escrita con el metodo Write()");

//¡Puede ejecutar todas estas lineas de codigo para ver el comportamiento. Prueba tambien,
//cambiando los valores y experimentando por tu cuenta!

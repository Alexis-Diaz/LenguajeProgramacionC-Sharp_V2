//La conversion de datos se presenta cuando queremos
//pasar un tipo de datos a otro tipo de datos.

//En C# existen dos tipos de conversiones:

//Conversion Implcita
//Se da cuando se convierte de un tipo de dato pequeño
//a otro de mayor tamaño
//char -> int -> long -> float -> double
int miEntero = 9;
double miDouble = miEntero; //Automaticamente se convierte
                            //de int a double
Console.WriteLine("CONVERSION IMPLICITA (AUTOMATICA)");
Console.WriteLine(miEntero);
Console.WriteLine(miDouble);

char miChar = '8';
int miInt = miChar;
Console.WriteLine(miChar);
Console.WriteLine(miInt);
Console.WriteLine();


//Conversion Explicita
//Se da cuando se convierte de un tipo de datos de mayot
//tamaño a uno de menor tamaño.
//double -> float -> long -> int -> char
double peso = 64.6;
int peso2 = (int)peso;
Console.WriteLine("CONVERSION EXPLICITA (MANUAL)");
Console.WriteLine(peso);
Console.WriteLine(peso2);

//Las conversiones explicitas tambien se pueden lograr con metodos de conversion.
//Esto es especualmente util cuando los tipos a convertir son incompatibles.

//string miNumero = "3488";
//int miNumero2 = (int)miNumero;//Error en tiempo de compilacion

string miNumero = "3488";
int miNumero2 = Convert.ToInt32(miNumero);//Error en tiempo de compilacion
Console.WriteLine(miNumero);
Console.WriteLine(miNumero2);



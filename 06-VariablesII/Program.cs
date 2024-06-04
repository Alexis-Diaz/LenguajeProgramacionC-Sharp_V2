//Una variable es un espacio en memoria para guardar un valor
//Para crear una variable se debe declarar el tipo de de dato que contendra.

//Existe 16 tipos de datos en C#

//Tipos enteros numericos
sbyte numeroSbyte = 127;                 //                       -128 A 127                        |  8 bits
byte numeroByte = 255;                   //                          0 A 225                        |  8 bits
short numeroShort = 32767;               //                    -32,768 A 32,767                     | 16 bits
ushort numeroUShort = 65535;             //                          0 A 65,535                     | 16 bits
int numeroInt = 2147483647;              //             -2,147,483,648 A 2,147,483,647              | 32 bits
uint numeroUint = 4294967295;            //                          0 A 4,294,967,295              | 32 bits
long numeroLong = 9223372036854775807;   // -9,223,372,036,854,775,808 A 9,223,372,036,854,775,807  | 64 bits
ulong numeroULong = 18446744073709551615;//                          0 A 18.446.744.073.709.551.615 | 64 bits

//Tipos decimales
float numeroFloat = 9.123456F;
double numeroDouble = 9.123456789123456;
decimal numeroDecimal = 9.123456789123456789123456789M;

//Caracteres
char tipoChar = 'a';
string tipoStr = "texto largo";

//Logicos
bool tipoBool = false;

Console.WriteLine("TIPO DINAMICO");
//Tipo dinamico
//Su tipo lo toma en tiempo de ejecucion por lo que no requiere ser asignado en la creacion de 
//la variable.
dynamic tipoDynamic;
tipoDynamic = 1;
Console.WriteLine(tipoDynamic.GetType().ToString());
tipoDynamic = "cadena";
Console.WriteLine(tipoDynamic.GetType().ToString());
tipoDynamic = 'b';
Console.WriteLine(tipoDynamic.GetType().ToString());
tipoDynamic = true;
Console.WriteLine(tipoDynamic.GetType().ToString());
tipoDynamic = 9.8M;
Console.WriteLine(tipoDynamic.GetType().ToString());
Console.WriteLine();

//Tipo object
//Aunque se parece a dynamic, no lo es en realidad. El tipo sigue siendo object y se deben realizar
//conversiones explicitas para que adopte el tipo que deseamos.
object tipoObject;
tipoObject = "cadena";
Console.WriteLine(tipoObject.GetType().ToString());
tipoObject = 1;
Console.WriteLine(tipoObject.GetType().ToString());

//USO DE VAR
//A diferencia de dynamic, var siempre se debe inicializar para definir su valor. Despues de eso
//su tipo no puede cambiar.
var miVariable = "cadena";

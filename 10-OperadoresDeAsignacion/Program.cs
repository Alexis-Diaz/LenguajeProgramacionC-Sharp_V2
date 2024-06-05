//OPERADORES DE ASIGNACION
//Los operadores de asignacion son utilizados para 
//asignar valores a las variables

//En el siguiente ejemplo el operador de asignacion =
//le asigna el valor 10 a la variable x.

int x = 10;
Console.WriteLine(x);
Console.WriteLine();

//Existe otras formas de utilizar el operador de
//asignacion en combinacion de otros operadores aritmeticos.

//ASGINACION DE SUMA
int a = 13;
int b = 23;
int c = 15;

//Ejemplos     Explicacion
a += 14;       //a = a + 14 = 27 | incrementa el valor en 14
b += b;        //b = b + b  = 46 | duplica el valor
c++;           //c = c + 1  = 16 | incrementa el valor en 1
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine();


//ASIGNACION DE RESTA
a = 13;
b = 23;
c = 15;

//Ejemplos     Explicacion
a -= 11;       //a = a - 11 = 2  | decrementa el valor en 11
b -= b;        //b = b - b  = 0  | resta el valor de si mismo
c--;           //c = c - 1  = 14 | decrementa el valor en 1
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine();


//ASIGNACION DE MULTIPLICACION
a = 13;
b = 23;

//Ejemplos     Explicacion
a *= 11;       //a = a * 11 = 143  | multiplica el valor en 11
b *= b;        //b = b * b  = 529  | multiplica el valor por si mismo
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();


//ASIGNACION DE DIVISION
a = 22;
b = 23;

//Ejemplos     Explicacion
a /= 11;       //a = a / 11 = 2  | divide el valor por 11
b /= b;        //b = b / b  = 1  | divide el valor por si mismo
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();


//ASIGNACION DE MODULO
a = 22;
b = 23;

//Ejemplos     Explicacion
a %= 11;       //a = a % 11 = 0  | extrae el residuo de la division por 11
b %= b;        //b = b % b  = 0  | extrae el residuo de la division por si mismo
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();


//ASIGNACION AND BIT A BIT
//Ejemplos 1
//En C#, el operador &= es un operador compuesto que realiza una operación AND bit a bit entre el valor
//de la variable y el valor proporcionado, luego asigna el resultado a la variable. Vamos a desglosar
//lo que hacen las instrucciones a &= 11; y b &= b;.
a = 14;
a &= 11;       //a =   a  &  11  = 10    | Esta instrucción realiza una operación AND bit a bit entre el valor de a y el valor 11
               //a = 1110 & 1011 = 1010  | 14 en binario es 1110, 11 en binario es 1011, 1010 (que es 10 en decimal)
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();

//Ejemplo 2
//Esta instrucción realiza una operación AND bit a bit del valor de b consigo mismo, lo que no cambia
//su valor, porque cualquier valor AND consigo mismo da el mismo valor.Es decir, cualquier número
//AND con sí mismo es igual a sí mismo:
b = 9;
b &= b;        //b =   b  &  b   =  9    | cualquier valor AND consigo mismo da el mismo valor
               //b = 1001 & 1001 = 1001  | 9 en binario es 1001
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();


//ASIGNACION OR BIT A BIT
a = 22;
b = 23;

//Ejemplos     Explicacion
a |= 11;       //a = a | 11 = 31  | extrae el residuo de la division por 11
b |= b;        //b = b | b  = 23  | Esta instrucción realiza una operación OR bit a bit del valor
               //                 | de b consigo mismo, lo que no cambia su valor, porque cualquier valor OR consigo
               //                 | mismo da el mismo valor
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();


//ASIGNACION XOR 
a = 22;
b = 23;

//Ejemplos     Explicacion
a ^= 11;       //a = a ^ 11 = 29  |
b ^= b;        //b = b ^ b  = 0   |

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();


//ASIGNACION DESPLAZAMIENTO A LA DERECHA
a = 22;
b = 23;

//Ejemplos     Explicacion
a >>= 11;       //a = a >> 11 = 0  | 
b >>= b;        //b = b >> b  = 0  | 

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();


//ASIGNACION DESPLAZAMIENTO A LA IZQUIERDA
a = 22;
b = 23;

//Ejemplos     Explicacion
a <<= 11;       //a = a << 11 = 45056      | 
b <<= b;        //b = b << b  = 192937984  | 

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();

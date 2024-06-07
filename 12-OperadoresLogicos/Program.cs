// Operator | Name	        | Description                     	                       |   Example
// && 	    | Logical and	| Returns True if both statements are true	               |   x < 5  &&  x < 10	
// || 	    | Logical or	| Returns True if one of the statements is true	           |   x < 5  ||  x < 4	
// !	    | Logical not	| Reverse the result, returns False if the result is true  | !(x < 5  &&  x < 10)

//Ejemplo
int x = 5;
int y = 6;
int z = 4;
Console.WriteLine(x < y && x < z); //false

Console.WriteLine(x < y || x < z); // true

Console.WriteLine(!(x < y && x < z));// false pero invertido es true

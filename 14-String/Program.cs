//Una variable string es un objeto que contiene elementos de tipo char en su
//interior. Este es un tipo especial y contiene propiedades y
//metodos que permiten realizar operaciones sobre las variables
//de tipo string.

//PROPIEDADES
//LENGTH
//Es una propiedad que indica la longitud o cantidad
//de caracteres que contiene (elementos char)
string alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
Console.WriteLine(alfabeto.Length);

//METODOS
string parrafo = "En la cima del acantilado, el faro iluminaba la noche, guiando a los marineros perdidos con su luz constante y serena.";
Console.WriteLine(parrafo.ToLower());
Console.WriteLine(parrafo.ToUpper());
Console.WriteLine(parrafo.Replace('a', '#'));
//El código parrafo.CompareTo(alfabeto) compara las dos cadenas parrafo y alfabeto,
//y devuelve un valor que indica si parrafo es menor, igual o mayor que alfabeto
//en términos de orden lexicográfico.
//-1 se ubica antes
//0 es igual
//1 viene despues
Console.WriteLine(parrafo.CompareTo(alfabeto));//out 1 porque parrafo viene despues que alfabeto.

Console.WriteLine(parrafo.IndexOf('c'));

//CONSTANTES
//Las constantes son valores inmutables que se conocen en tiempo de compilación y
//que no cambian durante la vida del programa. Las constantes se declaran con el
//modificador const.
//Solo los tipos integrados de C# se pueden declarar como const. Las constantes
//de tipo de referencia que no sean String solo se pueden inicializar con un
//valor null. 

//Se debe declarar e inicializar de una vez.

const int MiConstante = 70;
Console.WriteLine(MiConstante);

const MiClase miClase = null; //El valor asignado solo puede ser null aqui.
Console.WriteLine(miClase == null ? "null" : miClase.MyProperty);


class MiClase
{
    public string MyProperty { get; set; }
}
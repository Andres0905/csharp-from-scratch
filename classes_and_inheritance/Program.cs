// See https://aka.ms/new-console-template for more information
/* Clases*/
// var rect = new Rectangulo();
// rect.Base = 20;
// rect.Altura = 40;
// Console.WriteLine($"EL  area es : {rect.Area()}");
// Console.WriteLine($"EL  perimetro es : {rect.Perimetro()}");
/*End Clases*/

bool continuar =true;
while (continuar){
double a, b;

while (true)
{
    Console.WriteLine("Ingrese la Base: ");
    if (double.TryParse(Console.ReadLine(), out a))
    {
        break;
    }
    else
    {
        Console.WriteLine("Entrada Invalida. Ingrese Nuevamente el número");
    }
}

while (true)
{
    Console.WriteLine("Ingrese la Altura: ");
    if (double.TryParse(Console.ReadLine(), out b))
    {
        break;
    }
    else
    {
        Console.WriteLine("Entrada Invalida. Ingrese Nuevamente el número");
    }
}

var cuadr = new Cuadrado();
cuadr.Base = a;
cuadr.Altura = b;
Console.WriteLine($"EL  area es : {cuadr.Area()}");
Console.WriteLine($"EL  perimetro es : {cuadr.Perimetro()}");
Console.WriteLine($"EL  lado es : {cuadr.Lado}");


Console.WriteLine("Desea hacer otra operación? (s/n)");
string respuesta = Console.ReadLine().ToLower();
continuar = (respuesta == "s");

}
class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area() => Base * Altura;
    public double Perimetro() => 2 * Base + 2 * Altura;
}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }
    }
}
/*conditionals*/
//Console.WriteLine("Ingrese por favor un número: ");
//int num = int.Parse(Console.ReadLine());
//if (num > 0) Console.WriteLine("Positivo");
//else if (num < 0) Console.WriteLine("Negativo");
//else Console.WriteLine("Es cero");

/*End conditionals*/

/*Operators
Console.WriteLine("Ingrese por favor un número: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese por favor el segundo número: ");
double b = double.Parse(Console.ReadLine());
const string Indeterminado = "Indeterminado";
Console.WriteLine($"Suma: {a + b}, Resta: {a - b}, Multiplicación: {a * b}, División: {(b != 0 ? a / b : Indeterminado)}");
/*End Operators*/


bool continuar =true;
while (continuar){
double a, b;

while (true)
{
    Console.WriteLine("Ingrese el Primer número: ");
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
    Console.WriteLine("Ingrese el Primer número: ");
    if (double.TryParse(Console.ReadLine(), out b))
    {
        break;
    }
    else
    {
        Console.WriteLine("Entrada Invalida. Ingrese Nuevamente el número");
    }
}


Console.WriteLine("**Resultados**");
Console.WriteLine($"Suma: {Suma(a, b)}");
Console.WriteLine($"Resta: {Resta(a, b)}");
Console.WriteLine($"Multiplicación: {Multiplicacion(a, b)}");
Console.WriteLine($"División: {Division(a, b)}");

Console.WriteLine("Desea hacer otra operación? (s/n)");
string respuesta = Console.ReadLine().ToLower();
continuar = (respuesta == "s");

}

static double Suma(double a, double b)
{
    return a + b;
}

static double Resta(double a, double b)
{
    return a - b;
}

static double Multiplicacion(double a, double b)
{
    return a * b;
}

static string Division(double a, double b)
{
    if (b != 0)
    {
        return (a / b).ToString();
    }
    else
    {
        return "No se puede dividir por cero, valor indeterminado";
    }
}
using EspacioCalculadora;

Calculadora calc = new Calculadora();
int opcion = -1;

do
{
    Console.WriteLine("--CALCULADORA--");
    Console.WriteLine($"Valor actual {calc.Resultado}");
    Console.WriteLine("Elija una opción:");
    Console.WriteLine("[1].Sumar");
    Console.WriteLine("[2].Restar");
    Console.WriteLine("[3].Multiplicar");
    Console.WriteLine("[4].Dividir");
    Console.WriteLine("[5].Limpiar");
    Console.WriteLine("[0].Salir");
    Console.WriteLine("Opción: ");
    string opcionText = Console.ReadLine();

    if (int.TryParse(opcionText, out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese un numero");
                double numero = double.Parse(Console.ReadLine());
                calc.Sumar(numero);
                break;

            case 2:
                Console.Write("Escriba un número: ");
                numero = double.Parse(Console.ReadLine());
                calc.Restar(numero);
                break;

            case 3:
                Console.Write("Escriba un número: ");
                numero = double.Parse(Console.ReadLine());
                calc.Multiplicar(numero);
                break;

            case 4:
                Console.Write("Escriba un número: ");
                numero = double.Parse(Console.ReadLine());
                calc.Dividir(numero);
                break;

            case 5:
                calc.Limpiar();
                break;

            case 0:
                Console.WriteLine("Saliendo...");
                break;

            default:
                Console.WriteLine("Debe ingresar un numero entre [1] y [5].");
                break;
        }
    }
    else
    {
        Console.WriteLine("Debe ingresar un numero en vez de un texto.");
    }

} while (opcion != 0);
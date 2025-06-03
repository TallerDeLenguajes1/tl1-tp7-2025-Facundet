using EspacioEmpleados;

Empleado[] empleados = new Empleado[3];

//cargar datos
for (int i = 0; i < empleados.Length; i++)
{
    empleados[i] = new Empleado();

    Console.WriteLine("Ingrese el nombre: ");
    empleados[i].Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el apellido: ");
    empleados[i].Apellido = Console.ReadLine();

    Console.WriteLine("Ingrese la fecha de nacimiento con formato DD-MM-YYYY");
    empleados[i].FechaDeNacimiento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese estado civil: ");
    Console.WriteLine("[C].Casado");
    Console.WriteLine("[S].Soltero");
    empleados[i].EstadoCivil = char.Parse(Console.ReadLine().ToUpper());

    Console.WriteLine("Ingrese la fecha de ingreso a la empresa con formato DD-MM-YYYY");
    empleados[i].FechaIngresoToEmpresa = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Sueldo básico: ");
    empleados[i].SueldoBasico = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el cargo:");
    Console.WriteLine("[0].Administrativo.");
    Console.WriteLine("[1].Ingeniero.");
    Console.WriteLine("[2].Especialista.");
    Console.WriteLine("[3].Investigador.");

    int cargoSeleccionado = int.Parse(Console.ReadLine());
    empleados[i].cargo = (Cargos)cargoSeleccionado;
}

Console.WriteLine("Datos cargados!");


//ejercicio D
double totalSalarios = 0.0;
foreach (Empleado emp in empleados)
{
    totalSalarios += emp.CalcularSalario();
}
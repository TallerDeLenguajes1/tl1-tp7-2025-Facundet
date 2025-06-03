using System;
namespace EspacioEmpleados

{
    public enum Cargos
        {
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
    public class Empleado
    {
        public string Nombre;
        public string Apellido;
        public DateTime FechaDeNacimiento;
        public char EstadoCivil;
        public DateTime FechaIngresoToEmpresa;
        public double SueldoBasico;
        public Cargos cargo;

        public int MostrarAntiguedad()
        {
            DateTime hoy = DateTime.Now;
            int antiguedad = hoy.Year - FechaIngresoToEmpresa.Year;
            return antiguedad;
        }
        public int MostrarEdad() //paso parametros cuando vengan de fuera de la clase
        {
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - FechaDeNacimiento.Year;
            return edad;
        }

        public int RestForJubilation()
        {
            DateTime hoy = DateTime.Now;
            int edad = MostrarEdad();
            int rest = 65 - edad;
            return rest;
        }

        public double CalcularSalario()
        {
            int antiguedad = MostrarAntiguedad();
            double adicional = 0;

            // ejercicio b) i)
            if (antiguedad <= 20)
            {
                adicional = SueldoBasico * 0.01 * antiguedad;
            }
            else
            {
                adicional = SueldoBasico * 0.2;
            }

            // ii)
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional *= 1.50;
            }

            if (char.ToUpper(EstadoCivil) == 'C')
            {
                adicional += 150000;
            }
            double salarioTotal = SueldoBasico + adicional;
            return salarioTotal;
        }
    }
}
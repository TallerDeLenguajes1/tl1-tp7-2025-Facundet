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
    }
}
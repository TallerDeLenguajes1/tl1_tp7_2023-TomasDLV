using System;
using empresa;

namespace MiAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Juan";
            empleado1.Apellido = "Pérez";
            empleado1.FechaNac = new DateTime(1980, 5, 15);
            empleado1.EstadoCivil = 'S';
            empleado1.Genero = 'M';
            empleado1.FechaIngreso = new DateTime(2005, 7, 10);
            empleado1.SueldoBasico = 65000;
            empleado1.Cargo = Cargos.Ingeniero;

            Empleado empleado2 = new Empleado();
            empleado2.Nombre = "María";
            empleado2.Apellido = "Gómez";
            empleado2.FechaNac = new DateTime(1985, 9, 20);
            empleado2.EstadoCivil = 'C';
            empleado2.Genero = 'F';
            empleado2.FechaIngreso = new DateTime(2010, 3, 5);
            empleado2.SueldoBasico = 55000;
            empleado2.Cargo = Cargos.Administrativo;

            Empleado empleado3 = new Empleado();
            empleado3.Nombre = "Carlos";
            empleado3.Apellido = "López";
            empleado3.FechaNac = new DateTime(1975, 12, 8);
            empleado3.EstadoCivil = 'C';
            empleado3.Genero = 'M';
            empleado3.FechaIngreso = new DateTime(2000, 1, 15);
            empleado3.SueldoBasico = 75000;
            empleado3.Cargo = Cargos.Especialista;

            double totalSalarios = empleado1.CalcularSalario() + empleado2.CalcularSalario() + empleado3.CalcularSalario();
            Console.WriteLine("Monto total de salarios: " + totalSalarios);

            Empleado[] empleados = { empleado1, empleado2, empleado3 };

            Empleado empleadoProximoJubilarse = null;
            int aniosProximoJubilarse = int.MaxValue;

            foreach (var empleado in empleados)
            {
                int aniosParaJubilarse = empleado.AniosParaJubilarse();

                if (aniosParaJubilarse < aniosProximoJubilarse)
                {
                    empleadoProximoJubilarse = empleado;
                    aniosProximoJubilarse = aniosParaJubilarse;
                }
            }

            Console.WriteLine("Empleado más próximo a jubilarse:");
            Console.WriteLine("Nombre: " + empleadoProximoJubilarse.Nombre);
            Console.WriteLine("Apellido: " + empleadoProximoJubilarse.Apellido);
            Console.WriteLine("Fecha de Nacimiento: " + empleadoProximoJubilarse.FechaNac.ToShortDateString());
            Console.WriteLine("Estado Civil: " + empleadoProximoJubilarse.EstadoCivil);
            Console.WriteLine("Género: " + empleadoProximoJubilarse.Genero);
            Console.WriteLine("Fecha de Ingreso: " + empleadoProximoJubilarse.FechaIngreso.ToShortDateString());
            Console.WriteLine("Sueldo Básico: " + empleadoProximoJubilarse.SueldoBasico);
            Console.WriteLine("Cargo: " + empleadoProximoJubilarse.Cargo);
            Console.WriteLine("Años para jubilarse: " + aniosProximoJubilarse);
            Console.WriteLine("Salario correspondiente: " + empleadoProximoJubilarse.CalcularSalario());

            
        }
    }
}

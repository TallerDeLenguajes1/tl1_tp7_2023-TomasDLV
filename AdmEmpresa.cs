namespace empresa
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public int Antiguedad()
        {
            TimeSpan tiempoAntiguedad = DateTime.Now - FechaIngreso;
            return (int)tiempoAntiguedad.TotalDays / 365;
        }

        public int Edad()
        {
            TimeSpan tiempoEdad = DateTime.Now - FechaNac;
            return (int)tiempoEdad.TotalDays / 365;
        }

        public int AniosParaJubilarse()
        {
            int aniosParaJubilarse;

            if (Genero == 'F')
            {
                aniosParaJubilarse = 60 - Edad();
            }
            else
            {
                aniosParaJubilarse = 65 - Edad();
            }

            return Math.Max(aniosParaJubilarse, 0);
        }
        public double CalcularSalario()
        {
            double adicional = 0;

            int antiguedad = Antiguedad();

            if (antiguedad <= 20)
            {
                adicional = SueldoBasico * (antiguedad * 0.01);
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }

            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional += adicional * 0.5;
            }

            if (EstadoCivil == 'C')
            {
                adicional += 15000;
            }

            return SueldoBasico + adicional;
        }
    }
}
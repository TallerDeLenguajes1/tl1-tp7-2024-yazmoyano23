namespace EspacioEmpleado{
    public enum Cargo //Tipo de variable 
    {
        Auxiliar, 
        Administrativo, 
        Ingeniero,
        Especialista,
        Investigador,
    }

    public class Empleado
    {
        private string? nombre;

        private string? apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargo cargoEmpleado;
        const int edadJubilacion = 65;

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargo CargoEmpleado { get => cargoEmpleado; set => cargoEmpleado = value; }


        /* public Empleado(){ ASI DE ACCEDE AL UN VALOR QUE PUEDE TOMAR CARGO
        cargoEmpleado = Cargo.Investigador;
        }*/
        
        public int Antiguedad()
        {
            DateTime fechaActual = DateTime.Now;
            return fechaActual.Subtract(FechaIngreso).Days/ 365;
        }

        public int Edad()
        {
            DateTime fechaActual = DateTime.Now;
            return fechaActual.Subtract(FechaNacimiento).Days/ 365;
        }

            
        public int Jubilacion(int edad){
            return edadJubilacion - edad;
        }

        public double calculaSalario( int ant, double sueldoBasico, Cargo cargoEmpleado, char estadoCivil ){
            double salario, adicional = 0;

            string str1 = "Ingeniero";
            string str2 = "Especialista";

            if (ant < 20 )
            {
                adicional =  adicional + sueldoBasico * ant / 100;
            } else {
                adicional =  adicional + sueldoBasico * 25 / 100;
            }

            if ( str1.Equals(cargoEmpleado)|| str2.Equals(cargoEmpleado)) 
            {
                adicional =  adicional + adicional * 50 / 100;
            }

            if (estadoCivil == 'C')
            {
                adicional = adicional + 150000;
            }

            salario = sueldoBasico + adicional;
            return salario;
        }
    }
}



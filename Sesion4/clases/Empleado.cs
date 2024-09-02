namespace Sesion4.clases
{
    //Calcular el salario de el empleado
    internal class Empleado //Nombre comienza en mayusculo y singular
    {
        public Empleado() { } // 2 constructores uno vacio
        public int ID { get; set; }
        public string FirstName { get; set; } //Get obtener y Set establecer
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }

        public Empleado(int iD, string firstName, string lastName, string email, string phone, double salary) //Constructor con parametros
        {
            // this (yo tengo un atributo llamado ID)
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Salary = salary;
        }
    }
}
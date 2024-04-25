using System;
using System.Globalization;

namespace Funcionário
{
    class Funcionario
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id ,string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void AumentoSalary(double porcento)
        {
            Salary += Salary * porcento / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}


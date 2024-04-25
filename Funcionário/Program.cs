using Funcionário;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, name,  salary));
                Console.WriteLine();

            }

           Console.Write("Enter the employee id that will have salary increase: ");
            int procuraId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == procuraId);


            if (func != null)
            {
                Console.Write("Enter the percentage: ");
                double porcento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                func.AumentoSalary(porcento);
            }

            else
            {
                Console.WriteLine("This id does not exist!");
            }


            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);

            }

            
        }
    }
}
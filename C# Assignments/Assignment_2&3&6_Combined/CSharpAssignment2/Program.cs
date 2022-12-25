using System;

namespace CSharpAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee ID");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee salary");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter KM Travelled");
            double kmTravel = Convert.ToDouble(Console.ReadLine());

            //class Employee object
            Employee emp = new Employee(id, name, salary);
            emp.calculateSalary();
            emp.displayDetails();

            //Class Manager object
            Manager m = new Manager(id, name, salary);
            m.calculateSalary();
            displayManagerDetails d = new displayManagerDetails(m.displayDetails);
            d();

            //class MarketingExecutive object
            MarketingExecutive me = new MarketingExecutive(id, name, salary, kmTravel);
            me.calculateSalary();
            me.displayDetails();
            Console.ReadKey();
        }
    }
}

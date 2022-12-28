using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpAssignment2
{
    class Program
    {
        //Serializing and DeSerializing from assignment-7
        public static void SerializeObject(Object o)
        {
            FileStream fs = new FileStream(@"C:\Users\RAKERKAR\.Net-FullStack\C# Assignments\Assignment_2&3&6&7_Combined\output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, o);
            fs.Close();
        }

        public static void DeserializeObject()
        {
            FileStream fs = new FileStream(@"C:\Users\RAKERKAR\.Net-FullStack\C# Assignments\Assignment_2&3&6&7_Combined\output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Manager m1 = new Manager();
            m1 = (Manager)formatter.Deserialize(fs);
            Console.WriteLine($"-----Printing DeSerialized Manager Object-----\n{m1}");
            fs.Close();
        }

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

            //Serializing and DeSerializing from assignment-7
            SerializeObject(m);
            DeserializeObject();

            //class MarketingExecutive object
            MarketingExecutive me = new MarketingExecutive(id, name, salary, kmTravel);
            me.calculateSalary();


            //Delegate Creation from assignment-6
            displayManagerDetails d = new displayManagerDetails(m.displayDetails);
            d += me.displayDetails;
            d();

            Console.ReadKey();
        }
    }
}

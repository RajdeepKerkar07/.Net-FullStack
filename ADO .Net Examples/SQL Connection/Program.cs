using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            CRUD();
        }
        public static void CRUD()
        {
            SqlConnection con = null;
            try
            { 
                con = new SqlConnection(@"data source=LIN24003617\SQLEXPRESS; database=test; integrated security=SSPI");
                con.Open();
                int choice=0;
                do {
                    Console.WriteLine("Enter Choice");
                    Console.WriteLine("1.Display");
                    Console.WriteLine("2.Insert");
                    Console.WriteLine("3.Delete");
                    Console.WriteLine("4.Update");
                    Console.WriteLine("5.Search");
                    Console.WriteLine("6.Exit");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            SqlCommand display = new SqlCommand("select * from Employee", con);
                            SqlDataReader reader = display.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["EmpId"]} {reader["EmpName"]} {reader["Empsalary"]}");
                            }
                            reader.Close();
                            break;
                        case 2:
                            Console.WriteLine("Enter ID");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Salary");
                            int salary = Convert.ToInt32(Console.ReadLine());
                            SqlCommand insert = new SqlCommand($"insert into Employee values({id},'{name}',{salary})", con);
                            insert.ExecuteNonQuery();
                            Console.WriteLine("Inserted");
                            break;
                        case 3:
                            Console.WriteLine("Enter ID");
                            id = Convert.ToInt32(Console.ReadLine());
                            SqlCommand delete = new SqlCommand($"delete from Employee where EmpId = {id}", con);
                            delete.ExecuteNonQuery();
                            Console.WriteLine("Deleted");
                            break;
                        case 4:
                            Console.WriteLine("Enter ID");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter Salary");
                            salary = Convert.ToInt32(Console.ReadLine());
                            SqlCommand update = new SqlCommand($"update Employee set EmpName='{name}', EmpSalary={salary}", con);
                            update.ExecuteNonQuery();
                            Console.WriteLine("Updated");
                            break;
                        case 5:
                            Console.WriteLine("Enter ID");
                            id = Convert.ToInt32(Console.ReadLine());
                            SqlCommand search = new SqlCommand($"select * from Employee where EmpId ={id}", con);
                            SqlDataReader read = search.ExecuteReader();
                            while (read.Read())
                            {
                                Console.WriteLine($"{read["EmpId"]} {read["EmpName"]} {read["Empsalary"]}");
                            }
                            read.Close();
                            Console.WriteLine("Search complete");
                            break;
                        case 6:
                            break;
                        default:
                            Console.WriteLine("Enter valid choice.");
                            break;
                    }
                }
                while (choice != 6);
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            
            finally
            {
                con.Close();
            }
        }
    }
}
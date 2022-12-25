using System;

namespace Question6
{
    class Program
    {

        static void Main(string[] args)
        {
            Player[] India = new Player[5]
            {
                new Player("Rohit Sharma", 50),
                new Player("KL Rahul", 25),
                new Player("Virat Kohli", 75),
                new Player("Hardik Pandya", 60),
                new Player("Ashwin", 10),
            };

            Team teamList = new Team(India);
            foreach (Player p in teamList)
                Console.WriteLine(p.name + " " + p.runsScored);
        }
    }
}

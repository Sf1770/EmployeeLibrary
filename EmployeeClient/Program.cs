using System;
using EmployeeLibrary;

namespace EmployeeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //string output = person.GetPerson("Sabrina", "Fletcher", 25, 56372882);
            //string newPassKey = person.GetPassword("Sabrina", "56479202");
            //Console.WriteLine(newPassKey);
            //Console.ReadKey();

            // <-------------TYPE CASTING---------------->
            int a = 10;
            string b = Convert.ToString(a);
            Console.WriteLine(a + " " + b);
            string c = "123";
            long d = Convert.ToInt64(c);
            Console.WriteLine(d);

            /* <------------INHERITANCE-------------->
            Employee emp = new Employee(); //instance constructor
            var info = emp.GetPerson("Sabrina", "Fletcher", 27, 178863739);
            Employee Bryan = new Employee("Bryan", "Anderson", 24, 18393923);
            Manager mgr = new Manager();
            Console.WriteLine(info);
            */
            Console.Read();
        }
    }
}

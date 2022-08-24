using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp.LINQ
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }

        public override string ToString()
        {
            return $"{Id} -> {Name} -> {Price} -> {CompanyName}";

        }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string CityName { get; set; }

        public override string ToString()
        {
            return  $"{Id} {Name} {Salary} {CityName} ";

        }
    }

    class DemoObject
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
        {
            new Product{Id= 1, Name = "Mouse", Price = 799, CompanyName = "Dell"},
            new Product{Id= 2, Name = "Mouse", Price = 599, CompanyName = "HP"},
            new Product{Id= 3, Name = "Laptop", Price = 34799, CompanyName = "Dell"},
            new Product{Id= 4, Name = "Laptop", Price = 74599, CompanyName = "Lenovo"},
            new Product{Id= 5, Name = "Ram 4GB", Price = 2799, CompanyName = "Intel"},
            new Product{Id= 6, Name = "Speaker", Price = 1799, CompanyName = "Sony"},
            new Product{Id= 7, Name = "Mouse", Price = 999, CompanyName = "HP"},
            new Product{Id= 8, Name = "Laptop", Price = 54999, CompanyName = "HP"},
            new Product{Id= 9, Name = "Processor", Price = 12999, CompanyName = "Microsoft"},

        };

            //LINQ Queries
            var result1 = from p in products
                          select p;

            var result2 = from p in products
                          where p.Price < 2000
                          select p;

            var result3 = from p in products
                          where p.Price > 2000 && p.Price < 3000
                          select p;

            var result4 = from p in products
                          where p.CompanyName.StartsWith("D")
                          select p;

            var result5 = from p in products
                          where p.CompanyName.EndsWith("o")
                          select p;

            var result6 = from p in products
                          where p.CompanyName.Contains("e")
                          select p;

            var result7 = from p in products
                          where p.CompanyName.Contains("m") || p.CompanyName.Contains("M")
                          select p;

            var result8 = from p in products
                          where p.Price < 2500
                          orderby p.Price descending
                          select p;

            // Lambda expression
            var res = products.Where(p => p.Price < 2000).ToList();
            var res2 = products.Where(p => p.Price > 2000).OrderBy(x => x.Name).ToList();
            // retrive single record
            var res4 = products.Where(x => x.Id == 1).SingleOrDefault();
            var res3 = products.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Take(3);
            var res5 = products.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Skip(3);


           // foreach (Product prod in res5)
            {
            //    Console.WriteLine(prod);
            }

            Console.ReadKey();


            List<Employee> emp = new List<Employee>
            {
                new Employee {Id = 1, Name = "Dhiraj", Salary = 55000, CityName = "Nashik"},
                new Employee {Id = 2, Name = "Jaydeep", Salary = 50000, CityName = "Pune"},
                new Employee {Id = 3, Name = "Utkarsh", Salary = 65000, CityName = "Nashik"},
                new Employee {Id = 4, Name = "Jiendra", Salary = 45000, CityName = "Pune"},
                new Employee {Id = 5, Name = "Akib", Salary = 90000, CityName = "Mumbai"},
                new Employee {Id = 6, Name = "Manoj", Salary = 47000, CityName = "Pune"},
                new Employee {Id = 7, Name = "Manish", Salary = 100000, CityName = "Mumbai"},
                new Employee {Id = 8, Name = "Raj", Salary = 95000, CityName = "Nashik"},

            };

           // display all employees
            var result = from e in emp
                         select e;

           // display employee with asending order by name
            var r1 = from e in emp
                     orderby e.Name ascending
                     select e;

            //display employee whose salary is > 25000
            var r2 = from e in emp
                     where e.Salary > 25000
                     select e;

            //display employee whos from 'Pune' City
            var r3 = from e in emp
                     where e.CityName.Contains  ("Pune")
                     orderby e.Name
                     select e;

            //display employee with desending order by salary
            var r4 = from e in emp
                     orderby e.Salary descending
                     select e;

            //display employee whose name start with 'P'
            var r5 = from e in emp
                     where e.Name.StartsWith("P")
                     select e;

            //display employee whose salary is > 25000 & emp is from 'Mumbai' city
            var r6 = from e in emp
                     where e.Salary > 25000 && e.CityName.Contains("Mumbai")
                     select e;    

          //  foreach(Employee p in r1)
            {
          //      Console.WriteLine(p);
            }

            //Lambda Query
            // display all employees
            var o1 = emp.ToList();


            // display employee with asending order by name
            var o2 = emp.OrderBy(e => e.Name).ToList();


            //display employee whose salary is > 25000
            var o3 = emp.Where(e => e.Salary > 25000).OrderBy(e => e.Name).ToList();


            //display employee whos from 'Pune' City
            var o4 = emp.Where(e => e.CityName.Contains("Pune")).OrderBy(e => e.Name).ToList();


            //display employee with desending order by salary
            var o5 = emp.OrderByDescending(e => e.Salary).ToList();


            //display employee whose name start with 'P'
            var o6 = emp.Where(e => e.Name.StartsWith("P")).ToList();


            //display employee whose salary is > 25000 & emp is from 'Mumbai' city
            var o7 = emp.Where(e => e.Salary > 25000 && e.CityName.Contains("Mumbai")).ToList();

            foreach (Employee p1 in o1)
            {
                Console.WriteLine(p1);
            }

            Console.ReadKey();

        }
        
    }
}

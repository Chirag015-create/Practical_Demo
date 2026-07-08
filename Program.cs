using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program(); //created an object of class Program
            p.GetStudentDetails();
        }
        void GetStudentDetails()
        {
            int age;
            string name, dept;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your dept: ");
            dept = Console.ReadLine();

            Console.WriteLine("\n Welcome " + name + " You are from " + dept + " Your age is " + age);
            
            age = age + 1;
            name = name.ToUpper();
            dept = dept.ToUpper();

            Console.WriteLine("\n Welcome {0} You are study in  {1} Your age is {2} year old", name, dept, age);
        }
}

using CSharpProject.programming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student("Amit Kumar",25,350,"BCA");
            obj.GetStudent();
            Console.ReadKey();   
        }
    }
}

using CSharpProject.programming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Teacher : Polymorphism
    {
        //public Teacher(string _name, int _age, int _marks, string _className, StudentAddress _address) : base(_name,_age,_marks,_className,_address)
        //{
           
        //}
        public void Attendance()
        {
            Console.WriteLine("Teacher make attendance..");
        }
        new public void Display(string name, int fees, string className)
        {
            Console.WriteLine($"Teacher My name is {name} and i am study in {className} i give my fees {fees}");
        }
        static void Main(string[] args)
        {
            StudentAddress address = new StudentAddress("Ghaziabad", "201003");
            Student obj = new Student("Amit Kumar", 25, 350, "BCA", address);
            //Teacher teacher = new Teacher("Rahul Tyagi", 25, 380, "BCA", address);
            //teacher.GetStudentById();

            Teacher many = new Teacher();
            many.Display("Rahul",500,"5th");

            Console.ReadKey();
        }
    }
}

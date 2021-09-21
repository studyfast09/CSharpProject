using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.programming
{
    class Student
    {
        int  age, marks;
        string name,className;
        public Student(string _name, int _age, int _marks,string _className)
        {
            name = _name;
            age = _age;
            marks = _marks;
            className = _className;
        }
        public void GetStudent()
        {
            Console.WriteLine($"My name is {name} and i m {age} years old and i get {marks} in {className}");
        }
    }
}

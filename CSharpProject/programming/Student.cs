using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.programming
{
    class Student
    {
        int age, marks;
        string name,className;
        public StudentAddress address;
        public Student(string _name, int _age, int _marks,string _className, StudentAddress _address)
        {
            name = _name;
            age = _age;
            marks = _marks;
            className = _className;
            address = _address;
        }
        public void GetStudent()
        {
            Console.WriteLine($"My name is {name} and i m {age} years old and i get {marks} in {className}, my address is {address.city} and pincode : {address.pincode}");
        }
        protected void GetStudentById()
        {
            Console.WriteLine($"My name is {name} and i m {age} years old and i get {marks} in {className}, my address is {address.city} and pincode : {address.pincode}");
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueAndRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Id = 1;
            student.Name = "Shatrudhan";
            Update(student);
            Console.WriteLine(student.ToString()); //Id : 2 , Name :Anuj

            student.Id = 1;
            student.Name = "Shatrudhan";
            Update(student);
            Console.WriteLine(student.ToString()); //Id : 2 , Name :Anuj

            student.Id = 1;
            student.Name = "Shatrudhan";
            UpdateWithNewObj(student);
            Console.WriteLine(student.ToString()); //Id : 1 , Name :Shatrudhan

            student.Id = 1;
            student.Name = "Shatrudhan";
            UpdateByRefWithNewObj(ref student);
            Console.WriteLine(student.ToString()); //Id : 2 , Name :Anuj

        }

        static void Update(Student student)
        {
            student.Id = 2;
            student.Name = "Anuj";
        }

        static void UpdateByRef(ref Student student)
        {
            student.Id = 2;
            student.Name = "Anuj";
        }
        static void UpdateWithNewObj(Student student)
        {
            student=new Student();
            student.Id = 2;
            student.Name = "Anuj";
        }

        static void UpdateByRefWithNewObj(ref Student student)
        {
            student = new Student();
            student.Id = 2;
            student.Name = "Anuj";
        }

    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} , Name :{Name}";
        }
    }
}

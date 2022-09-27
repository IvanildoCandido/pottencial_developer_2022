using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesExplorer.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }
        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }
        public int GetStudentsQuantity()
        {
            return Students.Count;
        }
        public void ListStudents()
        {
            foreach (Person student in Students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
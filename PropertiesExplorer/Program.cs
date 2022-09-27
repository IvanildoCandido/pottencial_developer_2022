using PropertiesExplorer.Models;

Person person1 = new Person("Ivanildo");
Person person2 = new Person("Marizelma");
Course course = new Course();
course.Students = new List<Person>();

person1.Age = 35;
person1.Age = 27;
course.CourseName = "History";

course.AddStudent(person1);
course.AddStudent(person2);
Console.WriteLine(person1.Meeting());
course.ListStudents();
Console.WriteLine(
    $"Quantidade de alunos no curso: " +
    $"{course.CourseName}: {course.GetStudentsQuantity()}");
course.RemoveStudent(person2);
course.ListStudents();
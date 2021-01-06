using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student newStudent = new Student();
            newStudent.Name = "Ozlem";
            newStudent.StudentId = 1234;
            newStudent.NumberOfCredits = 1;
            newStudent.Gpa = 4.0;

            Console.WriteLine($"Student name: {newStudent.Name}\nStudentId:{newStudent.StudentId}\nCredit: {newStudent.NumberOfCredits}\nGPA: {newStudent.Gpa}");



            Teacher instructor = new Teacher();
            instructor.FirstName = "Benet";
            instructor.LastName = "Clark";
            instructor.Subject = "Web Development";
            instructor.YearsTeaching = 5;

            Console.WriteLine($"Instructor Name: {instructor.FirstName}\nLast Name:{instructor.LastName}\nSubject:{instructor.Subject}\nTeaching Years:{instructor.YearsTeaching}");



            Course newCourse = new Course();
            newCourse.studentNumber = 30;
            newCourse.List.Add("Python", 2);
            newCourse.List.Add("JavaScript", 12);
            newCourse.List.Add("C#", 16);
            newCourse.CourseName.Add("Python");
            newCourse.CourseName.Add("JavaScript");
            newCourse.CourseName.Add("C#");

            Console.WriteLine($"This course have {newCourse.studentNumber} student");

            foreach (string courseName in newCourse.CourseName)
            {
                Console.WriteLine($"This course have {courseName} classes");

            }

            foreach(KeyValuePair<string, int> person in newCourse.List)
            {
                Console.WriteLine($" {person.Value} student chose {person.Key} classes");

            }
            



        }
    }
}

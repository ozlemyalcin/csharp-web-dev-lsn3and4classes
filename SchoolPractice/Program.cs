using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            //ClassName variableName = new ClassName();

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


            //Generate a new Course
            Course math = new Course();
            math.Id = 202;
            math.Name = "Gemoetry";
            math.Length = 17;
            math.NumCredits = 4.0;

            math.Roster = new List<Student>();

            math.Roster.Add(newStudent);
            math.Roster.Add(new Student("Ben", 104, 1, 3.80));
            math.Roster.Add(new Student("Paul", 107, 2, 4.0));


            //Print info about Course
            Console.WriteLine($"{math.Name} ({math.Id})");
            Console.WriteLine("Roster:");


            foreach(Student student in math.Roster)
            {
                Console.WriteLine(student.Name);
            }






            /* my study
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
            */
            



        }
    }
}

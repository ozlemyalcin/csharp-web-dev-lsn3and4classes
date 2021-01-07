using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        /* my study
        private List<string> courseName = new List<string>();
        private Dictionary<string, int> list = new Dictionary<string, int>();


        public int studentNumber { get; set; }

        public List<string> CourseName
        {
            get { return courseName; }
            set { courseName = value; }

        }

        public Dictionary<string, int> List
        {
            get { return list; }
            set { list = value; }
        }
        */



        /*
         * Name: string
         * Length: int (numWeeks)
         * Roster: List<??>
         * NumCredits: double
         */
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public double NumCredits { get; set; }

        public List<Student> Roster { get; set; }



        public Course()
        {
            this.Roster = new List<Student>();

        }


        public void AddStudent(Student student)
        {

            if(this.Roster == null)
            {
                this.Roster = new List<Student>();


            }


            this.Roster.Add(student);

        }


       







    }
}
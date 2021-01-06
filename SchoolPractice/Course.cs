using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
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


    }
}
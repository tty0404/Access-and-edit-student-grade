using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assigment_3.Form1;

namespace Assigment_3
{
    internal class Student
    {

        private string studID;
        private string name;
        List<Course> courses;
        public Student(string name)
        {
            this.studID = Guid.NewGuid().ToString();
            this.courses = new List<Course>();
            this.name = name;
        }

        public string getStudID()
        {
            return studID;
        }
        public void setStudID(string studID)
        {
            this.studID = studID;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void addCourse(Course course)
        {
            if (this.courses.Count > 3)
            {
                throw new InvalidOperationException();
            }
            this.courses.Add(course);
        }
        public List<Course> getCourses()
        {
            return courses;
        }

        public string getCourseNamesAndMarks()
        {
            List<string> courseNameAndMarks = new List<string>();
            foreach (Course course in this.courses)
            {
                courseNameAndMarks.Add(course.getCourseNameAndMarkPiped());
            }
            return string.Join(",", courseNameAndMarks);
        }

    } 
}

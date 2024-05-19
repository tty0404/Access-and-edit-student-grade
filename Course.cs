using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_3
{
    internal class Course
    {
        private string courseID;
        private string name;
        private double mark;
        public Course(string name, double mark)
        {
            this.courseID = Guid.NewGuid().ToString();
            this.name = name;
            this.mark = mark;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public double getMark()
        {
            return this.mark;
        }
        public void setMark(double mark)
        {
            this.mark = mark;

        }

        public string getCourseNameAndMarkPiped()
        {
            return name + "| " + mark;
        }
        public string getCourseID()
        {
            return courseID;
        }
    }
}

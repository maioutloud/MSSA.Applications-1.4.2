using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_1._4._2
{
    internal class Student
    {
        // private *use camel case*
        private int studentId;
        private string studentFname;
        private string studentLname;
        private char studentGrade;

        // construct to initualize
        public Student(int id, string fname, string lname, char grade) 
        {
            studentId = id;
            studentFname = fname;
            studentLname = lname;
            studentGrade = grade;
        }
        // construct
        public Student()
        {
        }
        // public 
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string StudentFname
        {
            get { return studentFname; }
            set { studentFname = value; }
        }
        public string StudentLname
        {
            get { return studentLname; }
            set { studentLname = value; }
        }
        public char StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }
    }
}

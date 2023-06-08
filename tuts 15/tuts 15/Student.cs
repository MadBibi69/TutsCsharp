using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuts_15
{
    public class Student //Student class
    {

        //field or attributes
        public int IDno;
        public string Fullname;
        public string course;
        public int studentyear;
        public Student(int IDno, string Fullname, string course, int studentyear) //constractor
        {
            this.IDno = IDno;
            this.Fullname = Fullname;
            this.course = course;
            this.studentyear = studentyear;
        }
    }
}

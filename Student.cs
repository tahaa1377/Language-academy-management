using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modiriate_academy_zaban
{
    internal class Student : User
    {
        public int studentId { get; set; }
        public Student(int student_id , string name, string family, int age) : base(name, family, age)
        {
            studentId = student_id;
        }

        public int student_shahrie()
        {
            return this.studentId * 700;
        }


    }
}

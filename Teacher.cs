using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modiriate_academy_zaban
{
    internal class Teacher : User
    {
        public int TeacherCode { get; set; }
        public int salary { get; set; }

        public Teacher(int teacher_code,string name, string family, int age) : base(name, family, age)
        {
            TeacherCode = teacher_code;
        }

        public int calculate_salary()
        {
            salary = 1;
            salary*= 400 + this.TeacherCode;
            return salary;
        }

    }
}

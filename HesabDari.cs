using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modiriate_academy_zaban
{
    internal class HesabDari
    {
        public HesabDari() { }

        public static int student_shahrie(Student student)
        {
            return student.studentId * 700;
        }

        public static int calculate_salary_teacher(Teacher teacher)
        {
           teacher.salary = 1;
            teacher.salary *= 400 + teacher.TeacherCode;
            return teacher.salary;
        }

    }
}

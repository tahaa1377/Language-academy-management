namespace modiriate_academy_zaban
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("class days");
            foreach(var iteem in Class.class_days)
            {
                Console.WriteLine(iteem.ToString());
            }

            Teacher teacher1 = new Teacher(123, "ali", "alavi", 42);
            Teacher teacher2 = new Teacher(456, "vahid", "yadegarian", 34);
            Teacher teacher3 = new Teacher(468, "jamal", "ahmadi", 65);
            Teacher teacher4 = new Teacher(7644, "mohamad", "ap", 47);
            Teacher teacher5 = new Teacher(3462, "sara", "jalali", 29);

            Student student1 = new Student(001,"armin","eftekhary",20);
            Student student2 = new Student(002,"peyman","alavi",19);
            Student student3 = new Student(003,"mehdi","portalebi",18);
            Student student4 = new Student(004,"jafar","navidi",20);
            Student student5 = new Student(005,"zahra","moradi",20);

            Console.WriteLine("teacher list : ");
            Console.WriteLine(teacher1.ToString());
            Console.WriteLine(teacher2.ToString());
            Console.WriteLine(teacher3.ToString());
            Console.WriteLine(teacher4.ToString());
            Console.WriteLine(teacher5.ToString());


            Console.WriteLine("student list : ");
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());
            Console.WriteLine(student4.ToString());
            Console.WriteLine(student5.ToString());

            Console.WriteLine("hoghoogh teacher : ");
            Console.WriteLine(teacher1.calculate_salary());
            Console.WriteLine(teacher2.calculate_salary());
            Console.WriteLine(teacher3.calculate_salary());
            Console.WriteLine(teacher4.calculate_salary());
            Console.WriteLine(teacher5.calculate_salary());

            Console.WriteLine("shahrie students : ");
            Console.WriteLine(student1.student_shahrie());
            Console.WriteLine(student2.student_shahrie());
            Console.WriteLine(student3.student_shahrie());
            Console.WriteLine(student4.student_shahrie());
            Console.WriteLine(student5.student_shahrie());

            HesabDari.student_shahrie(student1);
            HesabDari.student_shahrie(student2);
            HesabDari.student_shahrie(student3);
            HesabDari.student_shahrie(student4);
            HesabDari.student_shahrie(student5);

            HesabDari.calculate_salary_teacher(teacher1);
            HesabDari.calculate_salary_teacher(teacher2);
            HesabDari.calculate_salary_teacher(teacher3);
            HesabDari.calculate_salary_teacher(teacher4);
            HesabDari.calculate_salary_teacher(teacher5);
        }
    }
}
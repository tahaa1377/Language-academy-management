namespace modiriate_academy_zaban
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Teacher>teachers= new List<Teacher>(); 
            List<Student>students= new List<Student>(); 
            List<Class>classes  = new List<Class>(); 


            Console.WriteLine("class days");
            foreach(var iteem in Class.class_days)
            {
                Console.WriteLine(iteem.ToString());
            }

            while (true)
            {
                Console.WriteLine("1- add teacher");
                Console.WriteLine("2- add student");
                Console.WriteLine("3- add class");
                Console.WriteLine("4- calculate salary teacher");
                Console.WriteLine("5- calculate hoghoogh student");
                Console.WriteLine("6- show list student");
                Console.WriteLine("7- show list teacher");

                string n = Console.ReadLine();

                if (n.Equals("1"))
                {
                    int code = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    string family = Console.ReadLine();
                    int age = Convert.ToInt32(Console.ReadLine());
                    Teacher teacher1 = new Teacher(code,name,family,age);
                    
                    teachers.Add(teacher1);
                    Console.WriteLine("teacher added");
                }
                else if(n.Equals("2"))
                {

                    int code = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    string family = Console.ReadLine();
                    int age = Convert.ToInt32(Console.ReadLine());
                    Student student1 = new Student(code, name, family, age);

                    students.Add(student1);
                    Console.WriteLine("student added");

                }
                else if(n.Equals("3"))
                {

                    string name = Console.ReadLine();
                    int number = Convert.ToInt32(Console.ReadLine());
                    Class c = new Class(name,number);

                    classes.Add(c);
                    Console.WriteLine("new Class added");

                }
                else if(n.Equals("4"))
                {
                    int code = Convert.ToInt32(Console.ReadLine());

                    foreach(var item in teachers)
                    {
                        if(item.TeacherCode == code)
                        {
                            Console.WriteLine(item.calculate_salary());
                        }
                    }

                }
                else if(n.Equals("5"))
                {

                    int code = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in students)
                    {
                        if (item.studentId == code)
                        {
                            Console.WriteLine(item.student_shahrie());
                        }
                    }

                }
                else if(n.Equals("6"))
                {

                    foreach (var item in students)
                    {
                       
                        Console.WriteLine(item);
                        
                    }

                }
                else if(n.Equals("7"))
                {
                    foreach (var item in teachers)
                    {

                        Console.WriteLine(item);

                    }
                }
            }
/*
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
            HesabDari.calculate_salary_teacher(teacher5);*/
        }
    }
}
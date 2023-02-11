using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modiriate_academy_zaban
{
    internal class User
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }

        public User(string name, string family, int age) {
        
            Name = name;
            Family = family;
            Age = age;
        }
        public override string ToString()
        {
            return Name +" "+ Family +" " + Age;
        }
    }
}

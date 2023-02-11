using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modiriate_academy_zaban
{
    internal class Class
    {

        public static string[] class_days = {"sunday", "monday", "fridey", "saterday" };
        public string Name { get; set; }
        public int Number { get; set; }


        public Class(string name, int number)
        {
            Name = name;
            Number = number;
        }



    }
}


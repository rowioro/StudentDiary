using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    class Person
    {
        string name;
        int age;
        string gender;


        public Person()
        {
            name = "Junior";
            age = 26;
            gender = "man";
        }

        public Person(string name, int age, string gender="man")
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
}

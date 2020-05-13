using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    public class Person
    {
        private string Name;
        private int Age;
        private string Sex;
        private DateTime Dateofbirth;
        private DateTime Dateofdeath;

        public Person(string name, int age, string sex, DateTime dateofbirth, DateTime dateofdeath)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Dateofbirth = dateofbirth;
            this.Dateofdeath = dateofdeath;
        }

    }
}

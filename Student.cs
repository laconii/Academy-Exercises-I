using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_practice
{
    //Student inheritates properties and method from class person
    class Student : Person
    {
        public int YearOfStudies;
        public string indexNumber;

        public Student(string firstname, string lastname, string sex, string jmbg, int yearofstudies, string indexnumber)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.Sex = sex;
            this.JMBG = jmbg;
            this.YearOfStudies = yearofstudies;
            this.indexNumber = indexnumber;
        }

        public override void Description()
        {
            Console.WriteLine("Hi, my name is {0} {1}, I'm a {2}. My JMBG is: {3}. \nThis is my {4} year of studies. My index number is: {5}", firstName, lastName, Sex, JMBG, YearOfStudies, indexNumber);
        }
    }
}

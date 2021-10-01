using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_practice
{
    //ABSTRACT CLASS
    abstract class Person
    {
        public Person()
        {

        }

        //PERSON PROPERTIES
        public string firstName;
        public string lastName;
        public string Sex;
        public string JMBG;
        public int numberJMBG;

        public Person(string firstname, string lastname, string sex, string jmbg)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.Sex = sex;
            this.JMBG = jmbg;
        }

        //Method for description of the person
        public virtual void Description()
        {
            Console.WriteLine("Hi, my name is {0} {1}, I'm a {2}. My JMBG is: {3}", firstName, lastName, Sex, JMBG);
        }

        //Validation of the JMBG
        public virtual void CheckJMBG()
        {
            if (JMBG.Length == 13)
            {
                Console.WriteLine("JMBG is valid: " + JMBG);
            }
            else
            {
                Console.WriteLine("JMBG is invalid.");
            }
        }
    }
}

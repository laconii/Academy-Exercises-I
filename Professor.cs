using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_practice
{
    class Professor : Person
    {
        //Student inheritates properties and method from class person
        public string Title;
        public Professor(string firstname, string lastname, string sex, string jmbg, string title)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.Sex = sex;
            this.JMBG = jmbg;
            this.Title = title;
        }

        public override void Description()
        {
            Console.WriteLine("Hi, my name is {0} {1}, I'm a {2}. My JMBG is: {3}. My title is {4}.", firstName, lastName, Sex, JMBG, Title);
        }

        public override void CheckJMBG()
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

using System;
using System.Collections.Generic;

namespace Academy_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Lazar", "Markovic", "Male", "0609199123562", 3, "2i1/0044/19");
            student.Description();

            Professor professor = new Professor("Suzana", "Markovic", "Female", "0922305943263", "Prof");
            professor.Description();
            professor.CheckJMBG();
        }
    }
}

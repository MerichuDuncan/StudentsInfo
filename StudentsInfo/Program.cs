using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfo
{
    class Program
    {
        static void Main(string[] args)


        {
            Student student1 = new Student("Marci Duncan", "Biology", "Cuyahoga Community College", "chue_3@yahoo.com", 440759850);
            Student student2 = new Student();



            //Console.WriteLine(student1.firstName + " " + lastName);

            student1.DisplayStudentInfo();


            student2.DisplayStudentInfo();
        }
    }
}

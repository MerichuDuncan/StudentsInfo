using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfo
{
    class Student
    {
        private string fullName;
        private string course;
        private string subject;
        private string university;
        private string emailAddress;
        private int phoneNumber;


        public Student(string fullName, string course, string subject, string university, string emailAddress, int phoneNumber)
        {

            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;

        //    public string fullName
        //{
        //    get { return this.firstName + " " + this.lastName; }
        //}
        }
        public Student(string fullName, string course, string university, string emailAddress, int phoneNumber)
        {
            this.fullName = fullName;
            this.course = course;
            this.university = university;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;

        }
        public Student()
        {
            this.fullName = "Stephen";
            this.course = "Software Developer";
            this.university = "Cleveland State University";
            this.emailAddress = "chue_3@yahoo.com";
            this.phoneNumber = 440759850;

        }


        public void DisplayStudentInfo()
        {
            Console.WriteLine("\nStudents fullName: " + fullName);
            Console.WriteLine("Students email adress: " + emailAddress);
            Console.WriteLine("Students phone number: " + phoneNumber);

        }
    }
}

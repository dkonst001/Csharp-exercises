using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student

    {
        public static int studentCount;
        private string _fullname;
        private string _course;
        private string _subject;
        private string _university;
        private string _eMail;
        private string _phoneNumber;
        private Student _nextStudent;

        public string FullName { get { return _fullname; } set { _fullname = value; } }
        public string Course { get { return _course; } set { _course = value; } }
        public string Subject { get { return _subject; } set { _subject = value; } }
        public string University { get { return _university; } set { _university = value; } }
        public string Email { get { return _eMail; } set { _eMail = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public Student NextStudent { get { return _nextStudent; } set { _nextStudent = value; } }

        public Student(string fullname)
        {
            this.FullName = fullname;

            this.Course = null;
            this.Subject = null;
            this.University = null;
            this.Email = null;
            this.PhoneNumber = null;
            this.NextStudent = null;
            studentCount++;

        }
        public Student(string fullname, string course)
        {
            this.FullName = fullname;
            this.Course = course;

            this.Subject = null;
            this.University = null;
            this.Email = null;
            this.PhoneNumber = null;
            this.NextStudent = null;
            studentCount++;

        }

        public Student(string fullname, string course, string subjuct)
        {
            this.FullName = fullname;
            this.Course = course;
            this.Subject = subjuct;

            this.University = null;
            this.Email = null;
            this.PhoneNumber = null;
            this.NextStudent = null;
            studentCount++;

        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Course: Course{1} Subject {2} University {3} e-mail {4} Phone {5}",
                FullName, Course, Subject, University, Email, PhoneNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    static class StudentTest
    {
        static Student firstStudent = null;
        static Student lastStudent = null;

        public static void AddStudent(string name, string course, string subject)
        {
            Student std = new Student(name, course, subject);
            if (lastStudent == null)
            {
                firstStudent = std;
                firstStudent.NextStudent = null;
                lastStudent = firstStudent;
            }
            else
            {
                lastStudent.NextStudent = std;
                lastStudent = std;
            }

        }

        public static Student FindStudent(string studentName)
        {
            Student tempStu = firstStudent;
            while (tempStu != null)
            {
                if (tempStu.FullName == studentName)
                {
                    Console.WriteLine(tempStu.ToString());
                    return tempStu;
                }

                tempStu = tempStu.NextStudent;
            }
            return null;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagmentApp.BLL
{

    public class StudentManager
    {
        StudentGateway aStudentGateway = new StudentGateway();
        public string Insert(Student student)
        {
            if (!IsRegNoExist(student))
            {
                aStudentGateway.InsertStudent(student);
                return "Student Entry Saved";
            }
            return "Registration Number is already Exist";
        }

        private bool IsRegNoExist(Student student)
        {
            return aStudentGateway.GetStudentRegNo(student);
        }

        public Student GetStudentInfo(string regNo)
        {
            return aStudentGateway.GetStudentInfo(regNo);
        }

        public List<Student> GetStudent()
        {
            return aStudentGateway.GetStudent();
        }
    }
}
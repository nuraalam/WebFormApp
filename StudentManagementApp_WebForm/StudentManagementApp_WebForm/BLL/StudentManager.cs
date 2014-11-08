using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using StudentManagementApp_WebForm.DAL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.BLL
{
    
    public class StudentManager
    {
        public StudentManager()
        {
            studentGateway = new StudentGateway();
        }

        StudentGateway studentGateway = new StudentGateway();
        public bool Insert(Student student)
        {
            int rowEffected = 0;
            if (!GetStudentByRegNo(student))
            {
                rowEffected=studentGateway.Insert(student);
            }
            return rowEffected>0;         
        }

        private bool GetStudentByRegNo(Student student)
        {
            Student retriveStudent = studentGateway.GetStudentByRegNo(student.RegNo);
            return retriveStudent!=null;
        }

        public List<Student> GetAllStudent()
        {
            return studentGateway.GetAllStudent();
        }

        public Student GetStudentByRegNo(string regNo)
        {
            return studentGateway.GetStudentByRegNo(regNo);
        }

        public List<Student> GetAllStudentByDepartment(int departmentId)
        {
            return studentGateway.GetAllStudentByDepartment(departmentId);
        }
    }
}
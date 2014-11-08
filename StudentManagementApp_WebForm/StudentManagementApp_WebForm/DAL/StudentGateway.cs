using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.DAL
{
    public class StudentGateway:Gateway
    {

        public StudentGateway():base("StudentConnectionString")
        {

          
        }
        public int Insert(Student student)
        {
            var query = "INSERT INTO Student (RegNo, Name,Email, DepartmentId) Values(@0,@1,@2,@3)";
            Command.Parameters.AddWithValue("@0", student.RegNo);
            Command.Parameters.AddWithValue("@1", student.Name);
            Command.Parameters.AddWithValue("@2", student.Email);
            Command.Parameters.AddWithValue("@3", student.DepartmentId);
            Command.CommandText = query;
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public List<Student> GetAllStudent()
        {
            List<Student> students = new List<Student>();
            var query = "SELECT * FROM Student";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();
            while (rdr.Read())
            {
                var student = new Student();
                student.RegNo = rdr["RegNo"].ToString();
                student.Name = rdr["Name"].ToString();
                student.Email = rdr["Email"].ToString();
                student.StudentId = Convert.ToInt32(rdr["StudentId"]);
                student.DepartmentId = (int) rdr["DepartmentId"];
                students.Add(student);
            }
            rdr.Close();
            Connection.Close();
            return students;
        }

        public Student GetStudentByRegNo(string regNo)
        {
            Student student = null;
            var query = "SELECT * FROM Student WHERE RegNo='"+regNo+"'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();
            while (rdr.Read())
            {
                    student = new Student();         
                    student.RegNo = rdr["RegNo"].ToString();
                    student.Name = rdr["Name"].ToString();
                    student.Email = rdr["Email"].ToString();
                    student.StudentId = Convert.ToInt32(rdr["StudentId"]);
                    student.DepartmentId = (int) rdr["DepartmentId"];
                
            }
            rdr.Close();
            Connection.Close();
            return student;   
        }

        public List<Student> GetAllStudentByDepartment(int departmentId)
        {
            List<Student> students = new List<Student>();
            var query = "SELECT * FROM Student WHERE departmentId='"+departmentId+"'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();
            while (rdr.Read())
            {
                var student = new Student();
                student.RegNo = rdr["RegNo"].ToString();
                student.Name = rdr["Name"].ToString();
                student.Email = rdr["Email"].ToString();
                student.StudentId = Convert.ToInt32(rdr["StudentId"]);
                student.DepartmentId = (int)rdr["DepartmentId"];
                students.Add(student);
            }
            rdr.Close();
            Connection.Close();
            return students;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace StudentManagmentApp.BLL
{
    public class StudentGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;
        private Student aStudent;

        private static void CallForConnection()
        {
            string conn = WebConfigurationManager.ConnectionStrings["WebUniversity"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }
        public bool GetStudentRegNo(Student student)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM StudentEntry");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            string name = "";
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    if (student.RegNo == aReader[0].ToString())
                        return true;
                }
                
            }
            connection.Close();
            return false;
        }

        public void InsertStudent(Student student)
        {
            CallForConnection();
            connection.Open();
            query = "INSERT INTO StudentEntry (RegNo,Name,Email,DepartmentID) Values(@0,@1,@2,@3)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0", student.RegNo);
            command.Parameters.AddWithValue("@1", student.Name);
            command.Parameters.AddWithValue("@2", student.Email);
            command.Parameters.AddWithValue("@3", student.DepartmentId);  
            command.ExecuteNonQuery();
            connection.Close();
        }

        public Student GetStudentInfo(string regNo)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM StudentEntry");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            string name = "";
            if (aReader.HasRows)
            {
                aStudent = new Student();
                while (aReader.Read())
                {
                    if (regNo == aReader[0].ToString())
                    {
                        aStudent.RegNo = aReader[0].ToString();
                        aStudent.Email = aReader[2].ToString();
                        aStudent.Name = aReader[1].ToString();
                        aStudent.ID = (int) aReader[3];
                    }
                }
            }
            connection.Close();
            return aStudent;
        }

        public List<Student> GetStudent()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM StudentEntry");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Student> students=new List<Student>();
            if (aReader.HasRows)
            {
               
                while (aReader.Read())
                {
                    aStudent = new Student();
                        aStudent.RegNo = aReader[0].ToString();
                        aStudent.Email = aReader[2].ToString();
                        aStudent.Name = aReader[1].ToString();
                        aStudent.ID = (int)aReader[3];
                        students.Add(aStudent);
                }
               
            }
            connection.Close();
            return students;
        }
    }
}
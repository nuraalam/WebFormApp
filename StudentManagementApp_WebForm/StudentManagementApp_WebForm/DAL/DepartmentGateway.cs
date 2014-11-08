using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.DAL
{
    public class DepartmentGateway:Gateway
    {
        public DepartmentGateway():base("StudentConnectionString")
        {

        }

        public int Insert(Department aDepartment )
        {
          // var query = @"INSERT INTO Department VALUES('" + aDepartment.Code + "','" + aDepartment.Name+ "')";


            var query = "INSERT INTO Department (Code, Name) Values(@0,@1)";
            Command.Parameters.AddWithValue("@0", aDepartment.Code);
            Command.Parameters.AddWithValue("@1", aDepartment.Name);
            Command.CommandText = query;

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }


        public Department GetStudentByCode(string code)
        {
            Department aDepartment = null;
            var query = "SELECT * FROM department WHERE Code = '" + code + "'";

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                aDepartment = new Department();
                aDepartment.Code = reader["Code"].ToString();
                aDepartment.Name = reader["Name"].ToString();             
                aDepartment.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
            }

            reader.Close();
            Connection.Close();
            return aDepartment;
        }

        public List<Department> GetAllDepartment()
        {
            
            var query = "SELECT * FROM department";

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();

            List<Department> departments = new List<Department>();

            while (rdr.Read())
            {
               Department aDepartment = new Department();
                aDepartment.Code = rdr["Code"].ToString();
                aDepartment.Name = rdr["Name"].ToString();
                aDepartment.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);
                departments.Add(aDepartment);
            }

            rdr.Close();
            Connection.Close();
            return departments;
        }
    }
}
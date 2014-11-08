using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace StudentManagmentApp
{
    public class DepartmentGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;    

        private static void CallForConnection()
        {
            string conn = WebConfigurationManager.ConnectionStrings["WebUniversity"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }
        public void SaveDepartment(Department aDepartment)
        {
            CallForConnection();
            connection.Open();
            query = "INSERT INTO DepartmentEntry (Code,Name) Values(@0,@1)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0", aDepartment.Code);
            command.Parameters.AddWithValue("@1", aDepartment.Name); 
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Department> GetDepartment()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM DepartmentEntry");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Department> departments=new List<Department>();
            if (aReader.HasRows)
            {

                while (aReader.Read())
                {
                    Department aDepartment=new Department();
                    aDepartment.Code = aReader[0].ToString();
                    aDepartment.Name = aReader[1].ToString();
                    aDepartment.ID = (int)aReader[2];
                    departments.Add(aDepartment);
                }

            }
            connection.Close();
            return departments;
        }
    }
}
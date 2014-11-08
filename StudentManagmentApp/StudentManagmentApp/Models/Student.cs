using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagmentApp
{
    public class Student
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegNo { get; set; }
        public int ID { get; set; }

        public Student(int departmentID, string name, string email, string regNo):this()
        {
            DepartmentId = departmentID;
            Name = name;
            Email = email;
            RegNo = regNo;
        }

        public Student()
        {
        }
    }
}
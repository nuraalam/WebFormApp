using System;

namespace StudentManagementApp_WebForm.Models
{
    [Serializable]
    public class Student
    {
        public Student(string name, string email, string regNo, int departmentId):this()
        {
            Name = name;
            Email = email;
            RegNo = regNo;
            DepartmentId = departmentId;
        }
        public Student()
        {
            
        }       
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegNo { get; set; }
        public int DepartmentId { get; set; }
        public int StudentId { get; set; }
    }
}
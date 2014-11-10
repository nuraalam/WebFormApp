using System;

namespace ManytoManyWeb
{
    [Serializable]
    public class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Student(string regNo, string name, string email)
        {
            RegNo = regNo;
            Name = name;
            Email = email;
        }
    }
}
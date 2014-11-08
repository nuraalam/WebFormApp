namespace StudentManagmentApp
{
    public class Department
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }

        public Department(string code, string name):this()
        {
            Code = code;
            Name = name;
        }

        public Department()
        {
        }
    }
}
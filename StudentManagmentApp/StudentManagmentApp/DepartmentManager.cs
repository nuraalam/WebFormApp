using System.Collections.Generic;

namespace StudentManagmentApp
{
    public class DepartmentManager
    {
        DepartmentGateway aDepartmentGateway = new DepartmentGateway();
        public string SaveDepartment(Department aDepartment)
        {
          
            aDepartmentGateway.SaveDepartment(aDepartment);
            return "Department Info Saved";
        }

        public List<Department> GetDepartment()
        {
            return aDepartmentGateway.GetDepartment();
        }
    }
}
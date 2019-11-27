using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystemMVC.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string BloodGroup { get; set; }
        public string Department { get; set; }
        public string Birthday { get; set; }
        public int NID { get; set; }


    }
}
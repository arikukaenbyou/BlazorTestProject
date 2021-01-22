using System;

namespace TrebasiewiczCompanyServer.Models

{ 
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string WorkLocation { get; set; }
        public string EmployeeType { get; set; }
        public int WorkingTimeValue { get; set; }
    }
}

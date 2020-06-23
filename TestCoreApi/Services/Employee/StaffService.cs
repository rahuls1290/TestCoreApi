using Models.Employee;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Employee
{
    public class StaffService : IStaffService
    {
        private static List<Staff> StaffList = new List<Staff>()
        {
            new Staff() { Id = 1, Name = "Renu", Address = "Bangalore", Department = "IT" },
            new Staff() { Id = 2, Name = "Kasi", Address = "Telangana", Department = "IT" },
            new Staff() { Id = 3, Name = "Rahul", Address = "Bangalore", Department = "HR" },
            new Staff() { Id = 4, Name = "Yatin", Address = "Bangalore", Department = "Management" },
            new Staff() { Id = 5, Name = "Arun", Address = "Kakinada", Department = "Testing" },
        };

        public Staff GetStaffById(int id)
        {
            return StaffList.Find(x => x.Id == id);
        }

        public List<Staff> GetsStaffList()
        {
            return StaffList;
        }
    }
}

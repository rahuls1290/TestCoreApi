using Models.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IStaffService
    {
        List<Staff> GetsStaffList();
        Staff GetStaffById(int id);
    }
}

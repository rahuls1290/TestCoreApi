using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Employee;
using Services.Interfaces;

namespace TestCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IStaffService staffService;

        public EmployeeController(IStaffService _staffService)
        {
            staffService = _staffService;
        }

        [Route("GetStaffById/{id}")]
        [HttpGet]
        public Staff GetStaffById(int id)
        {
            return staffService.GetStaffById(id);
        }

        [Route("GetStaffList")]
        [HttpGet]
        public List<Staff> GetStaffList()
        {
            return staffService.GetsStaffList();
        }
    }
}


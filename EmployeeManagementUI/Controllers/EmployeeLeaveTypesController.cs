using EmployeeManagment.BusinessEngine.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementUI.Controllers
{
    public class EmployeeLeaveTypesController : Controller
    {
        private readonly IEmployeeLeaveTypeBussinesEngine _employeeLeaveTypesBussinesEngine;
        public EmployeeLeaveTypesController(IEmployeeLeaveTypeBussinesEngine employeeLeaveTypesBussinesEngine)
        {
            _employeeLeaveTypesBussinesEngine = employeeLeaveTypesBussinesEngine;
        }
        public IActionResult Index()
        {
            var data = _employeeLeaveTypesBussinesEngine.GetAllEmpolyeeLeaveTypes();
            if (data.IsSuccess)
            {
                var result = data.Data;
                return View(result);
            }
            return View();
        }
    }
}

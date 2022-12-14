using System;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveAllocationVM :BaseVM
    {
        public int NumberOfDays { get; set; }

        public DateTime DataCreated { get; set; }
        public int Period { get; set; }

        public string EmployeeId { get; set; }
        public EmployeeVM EmployeeVm { get; set; }
        public int EmployeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveTypeVm { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Data.DbModels
{
    public class EmployeeLeaveRequest : BaseEntity
    {
        //----------------------------------------------------------//
        //Talepte Bulunan Kullanıcı Bilgileri
        public string RequestingEmployeeId { get; set; }
        [ForeignKey("RequestingEmployeeId")]
        public Employee RequestingEmployee { get; set; }
        //Onaylayan Bulunan Kullanıcı Bilgileri
        public string ApprovedEmployeeId { get; set; }
        [ForeignKey("ApprovedEmployeeId")]
        public Employee ApprovedEmployee { get; set; }

        public int EmployeeLeaveTypeId { get; set; }
        [ForeignKey("EmployeeLeaveTypeId")]
        public EmployeeLeaveType EmployeeLeaveType { get; set; }

        //----------------------------------------------------------//
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public String RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool? Cancelled { get; set; }

    }
}

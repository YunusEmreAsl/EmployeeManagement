﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveRequestVM : BaseVM
    {
        //Talepte Bulunan Kullanıcı Bilgileri
        public string RequestingEmployeeId { get; set; }
        public EmployeeVM RequestingEmployee { get; set; }
        //Onaylayan Bulunan Kullanıcı Bilgileri
        public string ApprovedEmployeeId { get; set; }
        public EmployeeVM ApprovedEmployee { get; set; }

        public int EmployeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveType { get; set; }

        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        [Display(Name="Talep Açıklama")]
        [MaxLength(300, ErrorMessage ="300 Karakterden Fazla Değer Girilemez")]
        public String RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool? Cancelled { get; set; }

    }
}

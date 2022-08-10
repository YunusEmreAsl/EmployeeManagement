using EmployeeManagement.Common.ResultModels;
using EmployeeManagement.Data.DbModels;
using System.Collections.Generic;

namespace EmployeeManagment.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveTypeBussinesEngine
    {
        Result<List<EmployeeLeaveType>>GetAllEmpolyeeLeaveTypes();
    }
}

using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.Data.İmplementaion
{
    public class EmployeeLeaveTypeRepository : Repository<EmployeeLeaveType>, IEmployeeLeaveTypeRepository
    {
        private readonly MyEmployeeManagementContext _ctx;
        public EmployeeLeaveTypeRepository(MyEmployeeManagementContext ctx) : base(ctx)
        {
             
        }
    }
}

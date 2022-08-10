using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.Data.İmplementaion
{
    public class EmployeeLeaveRequestRepository : Repository<EmployeeLeaveRequest> , IEmployeeLeaveRequestRepository
    {
        private readonly MyEmployeeManagementContext _ctx;

        public EmployeeLeaveRequestRepository(MyEmployeeManagementContext ctx)
            : base(ctx)
        {
            
        }
    }
}

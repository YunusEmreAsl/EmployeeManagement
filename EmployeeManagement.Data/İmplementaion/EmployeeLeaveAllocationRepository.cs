using EmployeeManagement.Data.Contracts;
using System;
using System.Linq;
using System.Linq.Expressions;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.Data.İmplementaion
{
    public class EmployeeLeaveAllocationRepository : Repository<EmployeeLeaveAllocation>, IEmployeeLeaveAllocationRepository
    {
        private readonly MyEmployeeManagementContext _ctx;

        public EmployeeLeaveAllocationRepository(MyEmployeeManagementContext ctx) 
            :base(ctx)
        {
            _ctx = ctx;
        }
    }
}

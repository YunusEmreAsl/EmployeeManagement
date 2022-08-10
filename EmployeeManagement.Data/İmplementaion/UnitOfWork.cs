using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using System;

namespace EmployeeManagement.Data.İmplementaion
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyEmployeeManagementContext _ctx;
        public UnitOfWork(MyEmployeeManagementContext ctx)
        {
            _ctx = ctx;
            employeeLeaveAllocation = new EmployeeLeaveAllocationRepository(_ctx);
            employeeLeaveRequestRepository = new EmployeeLeaveRequestRepository(_ctx);
            employeeLeaveTypeRepository = new EmployeeLeaveTypeRepository(_ctx);
        }
        public IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get; private set; }
        public IEmployeeLeaveRequestRepository employeeLeaveRequestRepository { get; private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; private set; }
        public void Dispose()
        {
            _ctx.Dispose();
        }
        public void Save()
        {
            _ctx.SaveChanges();
        }

    }
}

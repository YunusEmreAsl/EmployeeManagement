using EmployeeManagement.Data.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data.DataContext
{
    public class MyEmployeeManagementContext : IdentityDbContext
    {
        public MyEmployeeManagementContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeLeaveAllocation> EmployeeLeaveAllocations { get; set; }
        public DbSet<EmployeeLeaveType> EmployeeLeaveTypes { get; set; }
        public DbSet<EmployeeLeaveRequest> EmployeeLeaveRequests { get; set; }
    }
}

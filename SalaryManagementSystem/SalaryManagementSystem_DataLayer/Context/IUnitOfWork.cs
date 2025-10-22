using SalaryManagementSystem_DataLayer.DataModel;
using SalaryManagementSystem_DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagementSystem_DataLayer.Context
{
    public interface IUnitOfWork : IDisposable
    {

        IGenericRepository<Login> LoginRepository { get; }
        IGenericRepository<Employee> EmployeeRepository { get; }
        IGenericRepository<Department> DepartmentRepository { get; }
        IGenericRepository<Payment> PaymentRepository { get; }
        IGenericRepository<Manage> ManageRepository { get; }
        IGenericRepository<Skill> SkillRepository { get; }
        new void Dispose();
        void Save();

    }
}

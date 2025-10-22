using SalaryManagementSystem_DataLayer.DataModel;
using SalaryManagementSystem_DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagementSystem_DataLayer.Context
{
    public class UnitOfWork : IDisposable , IUnitOfWork 
    {
        SalaryManagementDBEntities db = new SalaryManagementDBEntities();


        private IGenericRepository<Login> _loginRepository;
        public IGenericRepository<Login> LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }
        private IGenericRepository<Employee> _employeeRepository;
        public IGenericRepository<Employee> EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new GenericRepository<Employee>(db);
                }
                return _employeeRepository;
            }
        }
        private IGenericRepository<Department> _departmentRepository;
        public IGenericRepository<Department> DepartmentRepository
        {
            get
            {
                if (_departmentRepository == null)
                {
                    _departmentRepository = new GenericRepository<Department>(db);
                }
                return _departmentRepository;
            }
        }
        private IGenericRepository<Payment> _paymentRepository;
        public IGenericRepository<Payment> PaymentRepository
        {
            get
            {
                if (_paymentRepository == null)
                {
                    _paymentRepository = new GenericRepository<Payment>(db);
                }
                return _paymentRepository;
            }
        }
        private IGenericRepository<Manage> _manageRepository;
        public IGenericRepository<Manage> ManageRepository
        {
            get
            {
                if (_manageRepository == null)
                {
                    _manageRepository = new GenericRepository<Manage>(db);
                }
                return _manageRepository;
            }
        }
        private IGenericRepository<Skill> _skillRepository;
        public IGenericRepository<Skill> SkillRepository
        {
            get
            {
                if (_skillRepository == null)
                {
                    _skillRepository = new GenericRepository<Skill>(db);
                }
                return _skillRepository;
            }
        }


        public void Dispose()
        {
            db.Dispose();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}

using AutoMapper;
using BusinessEntities;
using DataModel;
using DataModel.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessServices
{
    public class EmployeeService :IEmployeeService
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>  
        /// Public constructor.  
        /// </summary>  
        public EmployeeService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>  
        /// Public method to authenticate user by user name and word.  
        /// </summary>  
        /// <param name="userName"></param>  
        /// <param name="word"></param>  
        /// <returns></returns>  
        public long Authenticate(string email, string password)
        {
            var user = _unitOfWork.EmployeeRepository.Get(u => u.Email == email && u.Password == u.Password);
            if (user != null && user.Id > 0)
            {
                return user.Id;
            }
            return 0;

        }

        public long CreateEmployee(BusinessEntities.EmployeeEntity employee)
        {
            if (!checkEmployeeExists(employee.Email))
            {
                using (var scope = new TransactionScope())
                {
                    var newUser = new Employee
                    {
                        CompanyId = employee.CompanyId,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Email = employee.Email,
                        Password = employee.Password,
                        Contact = employee.Contact,
                        Created = DateTime.Now,
                        EmployeeCode = employee.EmployeeCode,
                        DOB = employee.DOB,
                        Alias = employee.Alias,
                        Gender = employee.Gender,
                        CreatedBy = employee.CreatedBy
                    };
                    _unitOfWork.EmployeeRepository.Insert(newUser);
                    _unitOfWork.Save();
                    scope.Complete();
                    return newUser.Id;
                }
            }
            else{
                return 0;
            }
        }

        public IEnumerable<BusinessEntities.EmployeeEntity> GetAllEmployees()
        {
            var employees = _unitOfWork.EmployeeRepository.GetAll().ToList();
            if (employees.Any())
            {
                Mapper.Initialize(cfg =>
                   {
                       cfg.CreateMap<Employee,EmployeeEntity>();
                   });

                var employeesModel = Mapper.Map<List<Employee>, List<EmployeeEntity>>(employees);
                return employeesModel;
            }
            return null;
        }

        public BusinessEntities.EmployeeEntity GetEmployeeById(long employeeId)
        {
            var employee = _unitOfWork.EmployeeRepository.Get(e => e.Id == employeeId);
            if (employee != null)
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Employee, EmployeeEntity>();
                });

                var employeesModel = Mapper.Map<Employee, EmployeeEntity>(employee);
                return employeesModel;
            }
            return null;
        }

        public bool checkEmployeeExists(string email)
        {
            var employees = _unitOfWork.EmployeeRepository.Get(e => e.Email == email);
            return employees != null ? true : false;
        }
    }
}

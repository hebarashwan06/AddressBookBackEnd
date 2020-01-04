using AddressBookDemo.DataAccess.Interfaces;
using AddressBookDemo.DataMapping.Entities;
using AddressBookDemo.DataMapping.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookDemo.DataAccess
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly ApplicationdbContext db;

        public EmployeeRepository(ApplicationdbContext db)
        {
            this.db = db;
        }

        

        public List<EmployeeVM> GetList()
        {
            var employees = db.Employees.Select(emp => new EmployeeVM
            {
                Employee=emp,
                Department=emp.Department,
                Job=emp.Job,
                Addresses=emp.addresses.ToList(),
                Phones=emp.Phones.ToList()

            }).ToList();
            return employees;
        }

        public EmployeeVM GetById(int id)
        {
            var employee = db.Employees.Select(emp => new EmployeeVM
            {
                Employee = emp,
                Department = emp.Department,
                Job = emp.Job,
                Addresses = emp.addresses.ToList(),
                Phones = emp.Phones.ToList()

            }).FirstOrDefault();
            return employee;
        }



        public void Insert(EmployeeVM model)
        {
            db.Employees.Add(model.Employee);
            foreach (var address in model.Addresses)
            {
                model.Employee.addresses.Add(address);
            }
            foreach (var phone in model.Phones)
            {
                model.Employee.Phones.Add(phone);
            }
            db.SaveChanges();
        }

        
        public void Update(EmployeeVM empVM)
        {
            var model = GetById(empVM.Employee.Id);
            if (model.Employee!= null)
            {
                model.Employee.Age = empVM.Employee.Age;
                model.Employee.BirthDate = empVM.Employee.BirthDate;
                model.Employee.DepartmentId = empVM.Employee.DepartmentId;
                model.Employee.Email = empVM.Employee.Email;
                model.Employee.FullName = empVM.Employee.FullName;
                model.Employee.JobId = empVM.Employee.JobId;
                model.Employee.addresses = empVM.Employee.addresses;
                model.Employee.Phones = empVM.Employee.Phones;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var model = GetById(id);
            if (model.Employee!=null)
            {
                db.Employees.Remove(model.Employee);
                db.SaveChanges();
            }
        }

        
    }
}

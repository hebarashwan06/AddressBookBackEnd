using AddressBookDemo.DataMapping.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDemo.DataAccess.Interfaces
{
    public interface IEmployeeRepository
    {
        List<EmployeeVM> GetList();

        EmployeeVM GetById(int id);

        void Insert(EmployeeVM model);

        void Update(EmployeeVM model);

        void Delete(int id);


    }
}

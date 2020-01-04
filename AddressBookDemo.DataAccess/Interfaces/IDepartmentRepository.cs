using AddressBookDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDemo.DataAccess.Interfaces
{
    public interface IDepartmentRepository
    {
        List<Department> GetList();
        Department GetById(int id);
        void Insert(Department department);
        void Update(Department department);
        void Delete(int id);
    }
}

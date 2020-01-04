using AddressBookDemo.DataAccess.Interfaces;
using AddressBookDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookDemo.DataAccess
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationdbContext db;

        public DepartmentRepository(ApplicationdbContext db)
        {
            this.db = db;
        }

        public List<Department> GetList()
        {
            return db.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return db.Departments.FirstOrDefault(d => d.Id == id);
        }

        public void Insert(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
        }

        public void Update(Department department)
        {
            var dept = db.Departments.FirstOrDefault(d=>d.Id==department.Id);
            if (dept!=null)
            {
                dept.Name = department.Name;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var dept = db.Departments.FirstOrDefault(d => d.Id == id);
            if (dept != null)
            {
                db.Departments.Remove(dept);
                db.SaveChanges();
            }
        }
    }
}

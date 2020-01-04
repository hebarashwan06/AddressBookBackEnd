using AddressBookDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDemo.DataAccess.Interfaces
{
    public interface IJobRepository
    {
        List<Job> GetList();
        Job GetById(int id);
        void Insert(Job job);
        void Update(Job job);
        void Delete(int id);
    }
}

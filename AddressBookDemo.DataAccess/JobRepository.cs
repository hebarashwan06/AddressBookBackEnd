using AddressBookDemo.DataAccess.Interfaces;
using AddressBookDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookDemo.DataAccess
{
    public class JobRepository : IJobRepository
    {
        private readonly ApplicationdbContext db;

        public JobRepository(ApplicationdbContext db)
        {
            this.db = db;
        }

        public List<Job> GetList()
        {
            return db.Jobs.ToList();
        }

        public Job GetById(int id)
        {
            return db.Jobs.FirstOrDefault(J => J.Id == id);
        }

        public void Insert(Job job)
        {
            db.Jobs.Add(job);
            db.SaveChanges();
        }

        public void Update(Job job)
        {
            var q = db.Jobs.FirstOrDefault(J => J.Id == job.Id);
            if (q!=null)
            {
                q.Title = job.Title;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var q = db.Jobs.FirstOrDefault(J => J.Id == id);
            if (q != null)
            {
                db.Jobs.Remove(q);
                db.SaveChanges();
            }
        }

    }
}

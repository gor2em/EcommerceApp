using Ecommerce.Repository.Abstraction.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Repository.Abstraction.Base
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _db; 
        protected Repository(DbContext db)
        {
            _db = db;
        }
        DbSet<T> Table
        {
            get { return _db.Set<T>(); }
        }
        public virtual void Add(T entity)
        {
            Table.Add(entity);
            _db.SaveChanges();
        }

        public ICollection<T> GetAll()
        {
            return Table.ToList();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public void Remove(T entity)
        {
            _db.Remove(entity);
            _db.SaveChanges();
        }

        public void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using System.Linq.Expressions;
using NerdSupport.Domain.Model;
using NerdSupport.Domain.Model.Repositories;

namespace NerdSupport.Domain.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        //private DatabaseContext dataContext;
        //private readonly IDbSet<T> dbset;

        //public Repository(IDataContextFactory databaseFactory)
        //{
        //    //DatabaseFactory = databaseFactory;
        //    //dbset = DataContext.Set<T>();
        //}

        //protected IDataContextFactory DatabaseFactory
        //{
        //    get;
        //    private set;
        //}

        //protected DatabaseContext DataContext
        //{
        //    get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        //}

        public virtual void Add(T entity)
        {
            BullshitDb<T>.Alla.Add(entity);
        }

        //public virtual void Update(T entity)
        //{
        //    dbset.Attach(entity);
        //    dataContext.Entry(entity).State = EntityState.Modified;
        //}

        //public virtual void Delete(T entity)
        //{
        //    dbset.Remove(entity);
        //}

        public virtual T GetById(long id)
        {
            return BullshitDb<T>.Alla.SingleOrDefault(f => f.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return BullshitDb<T>.Alla.ToList();
        }

        //public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        //{
        //    return dbset.Where(where).ToList();
        //}

        public T Get(Expression<Func<T, bool>> where)
        {
            return BullshitDb<T>.Alla.FirstOrDefault(where.Compile());
        }

        //public void SaveChanges()
        //{
        //    dataContext.SaveChanges();
        //}
    }
}

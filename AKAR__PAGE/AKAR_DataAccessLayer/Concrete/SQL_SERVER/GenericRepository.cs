using AKAR_DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_DataAccessLayer.Concrete.SQL_SERVER
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> 
        where TEntity : class , new() 
        where TContext : DbContext , new()
    {
        public void Add(TEntity item)
        {
            using (var context = new SQLCONTEXT())
            {
                context.Set<TEntity>().Add(item);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity item)
        {
            using (var context = new SQLCONTEXT())
            {
                context.Set<TEntity>().Remove(item);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new SQLCONTEXT())
            {
              return  context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new SQLCONTEXT())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity item)
        {
            using (var context = new SQLCONTEXT())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

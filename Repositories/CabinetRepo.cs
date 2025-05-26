using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repositories.Entities;

namespace Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbdesignQlchBansachContext _context = new();
        //private readonly DbSet<T> _dbSet;

        //public GenericRepository(DbdesignQlchBansachContext context)
        //{
        //    _context = context;
        //    _dbSet = context.Set<T>();
        //}

        public List<T> GetAll()
        {
            DbSet<T> dbSet = _context.Set<T>();
            return dbSet.AsNoTracking().ToList();
        }

        public void Add(T entity)
        {
            DbSet<T> dbSet = _context.Set<T>();
            dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            DbSet<T> dbSet = _context.Set<T>();
            dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            DbSet<T> dbSet = _context.Set<T>();
            dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public List<T> GetAllWithInclude(params Expression<Func<T, object>>[] includeExpressions)
        {
            IQueryable<T> query = _context.Set<T>();

            foreach (var includeExpression in includeExpressions)
            {
                query = query.Include(includeExpression);
            }

            return query.ToList();
        }


    }

}

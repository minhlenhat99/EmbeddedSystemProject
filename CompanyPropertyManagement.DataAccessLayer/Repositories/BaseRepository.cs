using CompanyPropertyManagement.Data.Context;
using CompanyPropertyManagement.DataAccessLayer.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CompanyPropertyManagement.DataAccessLayer.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> _dbSet;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public IQueryable<T> FindAll() => _dbSet;
        public IQueryable<T> FindAllByCondition(Expression<Func<T, bool>> expression) => _dbSet.Where(expression);
        public T FindById(Guid Id) => _dbSet.Find(Id);
        public void Create(T entity) => _dbSet.Add(entity);
        public void Update(T entity) => _dbSet.Update(entity);
        public void Delete(T entity) => _dbSet.Remove(entity);
    }
}

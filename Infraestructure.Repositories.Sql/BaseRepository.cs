using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Infraestructure.Repositories.Sql
{
    public class BaseRepository<TEntidad> : IRepository<TEntidad> where TEntidad : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntidad> _dbSet;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntidad>();
        }

        public void Add(TEntidad entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<TEntidad> FindAll()
        {
            return _dbSet.ToList();
        }

        public TEntidad Get(int id)
        {
            return _dbSet.Find(id);
        }

        public TEntidad Update(TEntidad entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}


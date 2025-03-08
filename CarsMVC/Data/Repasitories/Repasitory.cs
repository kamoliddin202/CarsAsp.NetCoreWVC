using CarsMVC.Data.Interfaces;
using CarsMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CarsMVC.Data.Repasitories
{
    public class Repasitory<TEntity> (AppDbContext appDbContext)
        : IRepasitory<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly DbSet<TEntity> _dbSet = appDbContext.Set<TEntity>();
        public void AddEntity(TEntity entity)
        {
            _dbSet.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void DeleteEntity(int id)
        {
            var enttiy = _dbSet.FirstOrDefault(c => c.Id == id);
            if (enttiy != null)
            {
                _appDbContext.Remove(enttiy);
                _appDbContext.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        => _dbSet.ToList();

        public TEntity GetById(int id)
        {
            var entity = _dbSet.FirstOrDefault(c => c.Id  == id);
            return entity;
        }

        public void UpdateEntity(TEntity entity)
        {
            _dbSet.Update(entity);
            _appDbContext.SaveChanges();
        }
    }
}

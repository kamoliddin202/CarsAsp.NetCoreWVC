using CarsMVC.Models;

namespace CarsMVC.Data.Interfaces
{
    public interface IRepasitory<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void AddEntity(TEntity entity);
        void UpdateEntity(TEntity entity);
        void DeleteEntity(int id);
    }
}

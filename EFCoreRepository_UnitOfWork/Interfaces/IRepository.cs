namespace EFCoreRepository_UnitOfWork.Interfaces
{
    public interface IRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    { }
}
﻿namespace EFCoreRepository_UnitOfWork.Interfaces
{
    public interface IReadRepository<TEntity> : IReadRepositoryBase<TEntity> where TEntity : class
    { }
}
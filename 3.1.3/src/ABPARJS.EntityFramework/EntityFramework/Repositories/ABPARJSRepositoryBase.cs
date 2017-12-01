using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPARJS.EntityFramework.Repositories
{
    public abstract class ABPARJSRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPARJSDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPARJSRepositoryBase(IDbContextProvider<ABPARJSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPARJSRepositoryBase<TEntity> : ABPARJSRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPARJSRepositoryBase(IDbContextProvider<ABPARJSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

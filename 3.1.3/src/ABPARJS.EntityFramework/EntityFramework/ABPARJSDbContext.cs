using System.Data.Common;
using Abp.Zero.EntityFramework;
using ABPARJS.Authorization.Roles;
using ABPARJS.Authorization.Users;
using ABPARJS.MultiTenancy;

namespace ABPARJS.EntityFramework
{
    public class ABPARJSDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABPARJSDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPARJSDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPARJSDbContext since ABP automatically handles it.
         */
        public ABPARJSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABPARJSDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABPARJSDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}

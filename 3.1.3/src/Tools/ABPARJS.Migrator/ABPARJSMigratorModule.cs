using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABPARJS.EntityFramework;

namespace ABPARJS.Migrator
{
    [DependsOn(typeof(ABPARJSDataModule))]
    public class ABPARJSMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABPARJSDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
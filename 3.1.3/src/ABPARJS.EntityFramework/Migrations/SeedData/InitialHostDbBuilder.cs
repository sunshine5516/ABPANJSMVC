using ABPARJS.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABPARJS.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPARJSDbContext _context;

        public InitialHostDbBuilder(ABPARJSDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

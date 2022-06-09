
using Microsoft.EntityFrameworkCore;


namespace Budget_Planner.Model
{
    internal class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=BudgetPlannerDb.db");
        }
        public DbSet<Balances> Balances { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoriesToOperationTypes> CategoryToOperationTypes { get; set; }
        public DbSet<Operations> Operations { get; set; }
        public DbSet<OperationTypes> OperationTypes { get; set; }
    }
}

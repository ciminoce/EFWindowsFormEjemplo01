namespace EFWindowsFormEjemplo01.Context
{
    public class UnitofWork:IUnitOfWork
    {
        private readonly CursosDbContext _dbContext;

        public UnitofWork(CursosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}

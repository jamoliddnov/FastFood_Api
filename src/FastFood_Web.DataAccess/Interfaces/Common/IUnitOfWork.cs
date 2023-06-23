namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface IUnitOfWork
    {

        public Task<int> SaveChangeAsync();
    }
}

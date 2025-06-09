using CleanArchitecture.DataAccess.IRepository;
using CleanArchitecture.DataAccess.Models;
using CleanArchitecture.DataAccess.Repsitory;


namespace CleanArchitecture.DataAccess.IUnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<T> Repository<T>() where T : ModelBase;

        Task<int> Complete();


        IApplicationUserRepository ApplicationUserRepository { get; }
    }
}

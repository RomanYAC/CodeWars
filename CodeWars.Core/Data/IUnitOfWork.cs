using System.Threading.Tasks;
using CodeWars.Core.Data.Repositories;

namespace CodeWars.Core.Data
{
    public interface IUnitOfWork
    {
        ICodingTaskRepository CodingTaskRepository { get; }
        IGradeRepository GradeRepository { get; }
        IParameterRepository ParameterRepository { get; }
        IRoleRepository RoleRepository { get; }
        ITestRepository TestRepository { get; }
        ITestTypeRepository TestTypeRepository { get; }
        ITestValueRepository TestValueRepository { get; }
        IUserRepository UserRepository { get; }
        Task SaveChangesAsync();
    }
}

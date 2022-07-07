using App.Domain.Entities;
using App.Infra.Repository.Interfaces.BaseInterfaces;

namespace App.Infra.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
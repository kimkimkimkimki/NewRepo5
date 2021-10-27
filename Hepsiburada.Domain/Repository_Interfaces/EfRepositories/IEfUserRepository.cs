using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Domain.Entities;
using Hepsiburada.Domain.Repository_Interfaces.EfRepositories.Base;

namespace Hepsiburada.Domain.Repository_Interfaces.EfRepositories
{
    public interface IEfUserRepository : IEfBaseRepository<User>
    {
    }
}

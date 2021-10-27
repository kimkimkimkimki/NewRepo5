using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Domain.Entities;
using Hepsiburada.Domain.Repository_Interfaces.EfRepositories;
using Hepsiburada.Infrastructure.Contexts;
using Hepsiburada.Infrastructure.Repositories.EfRepositories.Base;

namespace Hepsiburada.Infrastructure.Repositories.EfRepositories
{
    public class EfItemRepository : EfBaseRepository<Item>, IEfItemRepository
    {
        public EfItemRepository(EfDbContext context) : base(context)
        {
        }
    }
}

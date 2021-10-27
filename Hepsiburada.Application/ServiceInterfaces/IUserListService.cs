using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.TopListDTOs;

namespace Hepsiburada.Application.ServiceInterfaces
{
    public interface IUserListService
    {
        Task Create(CreateUserListDto user);
        Task<List<GetUserListDto>> GetAll();
        Task<GetUserListDto> GetById(int id);
        Task Update(int id, UpdateUserListDto user);
        Task Delete(int id);
    }
}

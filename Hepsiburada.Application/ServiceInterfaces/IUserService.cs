using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.UserDTOs;

namespace Hepsiburada.Application.ServiceInterfaces
{
    public interface IUserService
    {
        Task Create(CreateUserDto user);
        Task<List<GetUserDto>> GetAll();
        Task<GetUserDto> GetById(int id);
        Task Update(int id,UpdateUserDto user);
        Task Delete(int id);
    }
}

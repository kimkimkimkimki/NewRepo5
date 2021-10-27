using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.ItemDTOs;

namespace Hepsiburada.Application.ServiceInterfaces
{
    public interface IItemService
    {
        Task Create(CreateItemDto user);
        Task<List<GetItemDto>> GetAll();
        Task<GetItemDto> GetById(int id);
        Task Update(int id, UpdateItemDto user);
        Task Delete(int id);
    }
}

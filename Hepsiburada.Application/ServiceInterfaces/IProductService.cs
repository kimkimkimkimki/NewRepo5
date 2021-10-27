using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.ProductDTOs;

namespace Hepsiburada.Application.ServiceInterfaces
{
    public interface IProductService
    {
        Task Create(CreateProductDto user);
        Task<List<GetProductDto>> GetAll();
        Task<GetProductDto> GetById(int id);
        Task Update(int id, UpdateProductDto user);
        Task Delete(int id);
    }
}

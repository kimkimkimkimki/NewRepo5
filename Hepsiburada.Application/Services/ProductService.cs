using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hepsiburada.Application.DTOs.ProductDTOs;
using Hepsiburada.Application.ServiceInterfaces;
using Hepsiburada.Domain.Entities;
using Hepsiburada.Domain.Repository_Interfaces.EfRepositories;

namespace Hepsiburada.Application.Services
{
    public class ProductService:IProductService
    {
        private readonly IEfProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IEfProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Create(CreateProductDto productDto)
        {
            var entity = _mapper.Map<Product>(productDto);
            await _productRepository.Create(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await _productRepository.Where(user => user.Id == id);
            await _productRepository.Delete(entity);
        }

        public async Task<List<GetProductDto>> GetAll()
        {
            var list = await _productRepository.GetAll();
            return _mapper.Map<List<GetProductDto>>(list);
        }

        public async Task<GetProductDto> GetById(int id)
        {
            var entity = await _productRepository.Where(user => user.Id == id);
            return _mapper.Map<GetProductDto>(entity);
        }

        public async Task Update(int id, UpdateProductDto productDto)
        {
            var entity = await _productRepository.Where(u => u.Id == id);
            var updated = _mapper.Map(productDto, entity);

            await _productRepository.Update(updated);
        }
    }
}

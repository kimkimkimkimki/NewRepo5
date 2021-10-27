using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hepsiburada.Application.DTOs.ItemDTOs;
using Hepsiburada.Application.DTOs.ProductDTOs;
using Hepsiburada.Application.DTOs.UserDTOs;
using Hepsiburada.Application.ServiceInterfaces;
using Hepsiburada.Domain.Entities;
using Hepsiburada.Domain.Repository_Interfaces.EfRepositories;

namespace Hepsiburada.Application.Services
{
    public class ItemService:IItemService
    {
        private readonly IEfItemRepository _ıtemRepository;
        private readonly IMapper _mapper;
        private readonly IEfProductRepository _productRepository;
        public ItemService(IEfItemRepository ıtemRepository, IMapper mapper, IEfProductRepository productRepository)
        {
            _ıtemRepository = ıtemRepository;
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task Create(CreateItemDto ıtemDto)
        {
            var entity = _mapper.Map<Item>(ıtemDto);
            await _ıtemRepository.Create(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await _ıtemRepository.Where(user => user.Id == id);
            await _ıtemRepository.Delete(entity);
        }

        public async Task<List<GetItemDto>> GetAll()
        {
            var list = await _ıtemRepository.GetAll();
            return _mapper.Map<List<GetItemDto>>(list);
        }

        public async Task<GetItemDto> GetById(int id)
        {
            var entity = await _ıtemRepository.Where(u => u.Id == id);
            var getItemDto=_mapper.Map<GetItemDto>(entity);
            getItemDto.Product =_mapper.Map<GetProductDto>( await _productRepository.Where(p => p.Id == entity.ProductId));
            return getItemDto;
        }

        public async Task Update(int id, UpdateItemDto ıtemDto)
        {
            var entity = await _ıtemRepository.Where(u => u.Id == id);
            var updated = _mapper.Map(ıtemDto, entity);

            await _ıtemRepository.Update(updated);
        }
    }
}

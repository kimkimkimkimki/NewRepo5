using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hepsiburada.Application.DTOs.ItemDTOs;
using Hepsiburada.Application.DTOs.ProductDTOs;
using Hepsiburada.Application.DTOs.TopListDTOs;
using Hepsiburada.Application.ServiceInterfaces;
using Hepsiburada.Domain.Entities;
using Hepsiburada.Domain.Repository_Interfaces.EfRepositories;

namespace Hepsiburada.Application.Services
{
    public class UserListService:IUserListService
    {
        private readonly IEfUserListRepository _userListRepository;
        private readonly IEfUserRepository _userRepository;
        private readonly IEfItemRepository _ıtemRepository;
        private readonly IMapper _mapper;
        public UserListService(IEfUserListRepository userListRepository, IMapper mapper, 
            IEfUserRepository userRepository, IEfItemRepository ıtemRepository)
        {
            _userListRepository = userListRepository;
            _mapper = mapper;
            _userRepository = userRepository;
            _ıtemRepository = ıtemRepository;
        }

        public async Task Create(CreateUserListDto topListDto)
        {
            var entity = _mapper.Map<UserList>(topListDto);
            await _userListRepository.Create(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await _userListRepository.Where(user => user.Id == id);
            await _userListRepository.Delete(entity);
        }

        public async Task<List<GetUserListDto>> GetAll()
        {
            var list = await _userListRepository.GetAll();
            var topListDto=_mapper.Map<List<GetUserListDto>>(list);
            foreach (var topList in topListDto)
            {
                topList.UserNameSurName =  ShowUserToTopList(topList);
                var topListEntity = _mapper.Map<UserList>(topList);
                topList.Items = _mapper.Map<List<GetItemDto>>(_ıtemRepository.GetAll().Result.Where(i => i.TopListId == topListEntity.Id).ToList());
                
            }

            return topListDto;
        }

        public async Task<GetUserListDto> GetById(int id)
        {
            var entity = await _userListRepository.Where(u => u.Id == id);
            var showTopList = _mapper.Map<GetUserListDto>(entity);
            showTopList.UserNameSurName = ShowUserToTopList(showTopList);
            showTopList.Items =_mapper.Map<List<GetItemDto>>(_ıtemRepository.GetAll().Result.Where(i => i.TopListId == id).ToList());
            return showTopList;
        }

        public async Task Update(int id, UpdateUserListDto topListDto)
        {
            var entity = await _userListRepository.Where(u => u.Id == id);
            var updated = _mapper.Map(topListDto, entity);

            await _userListRepository.Update(updated);
        }

        private string ShowUserToTopList(GetUserListDto topList)
        {
            var entity = _userRepository.Where(u => u.Id == topList.UserId).Result;
            string returnData = $"{entity.Name} {entity.Surname}";
            return returnData;
        }

    }
}

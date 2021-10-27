using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hepsiburada.Application.DTOs.UserDTOs;
using Hepsiburada.Application.ServiceInterfaces;
using Hepsiburada.Domain.Entities;
using Hepsiburada.Domain.Repository_Interfaces.EfRepositories;
using Hepsiburada.Infrastructure.Repositories.EfRepositories;

namespace Hepsiburada.Application.Services
{
    public class UserService:IUserService
    {
        private readonly IEfUserRepository _efUserRepository;
        private readonly IMapper _mapper;

        public UserService(IEfUserRepository efUserRepository, IMapper mapper)
        {
            _efUserRepository = efUserRepository;
            _mapper = mapper;
        }

        public async Task Create(CreateUserDto user)
        {
            var entity = _mapper.Map<User>(user);
            await _efUserRepository.Create(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await _efUserRepository.Where(user => user.Id == id);
            await _efUserRepository.Delete(entity);
        }

        public async Task<List<GetUserDto>> GetAll()
        {
            var list =await _efUserRepository.GetAll();
            return _mapper.Map<List<GetUserDto>>(list);
        }

        public async Task<GetUserDto> GetById(int id)
        {
            var entity=await _efUserRepository.Where(user => user.Id == id);
            return _mapper.Map<GetUserDto>(entity);
        }

        public async Task Update(int id,UpdateUserDto user)
        {
            var entity = await _efUserRepository.Where(u=>u.Id==id);
            var updated = _mapper.Map(user,entity);

            await _efUserRepository.Update(updated);
        }
    }
}

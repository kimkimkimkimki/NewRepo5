using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hepsiburada.Application.DTOs.ItemDTOs;
using Hepsiburada.Application.DTOs.ProductDTOs;
using Hepsiburada.Application.DTOs.TopListDTOs;
using Hepsiburada.Application.DTOs.UserDTOs;
using Hepsiburada.Domain.Entities;

namespace Hepsiburada.Application
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<UserList, CreateUserListDto>().ReverseMap();
            CreateMap<UserList, UpdateUserListDto>().ReverseMap();
            CreateMap<UserList, GetUserListDto>().ReverseMap();
            CreateMap<Item, CreateItemDto>().ReverseMap();
            CreateMap<Item, UpdateItemDto>().ReverseMap();
            CreateMap<Item, GetItemDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();

        }

    }
}

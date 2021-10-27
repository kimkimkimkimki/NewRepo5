using Hepsiburada.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.ItemDTOs;

namespace Hepsiburada.Application.DTOs.TopListDTOs
{
    public class GetUserListDto
    {
        public string ListName { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public string UserNameSurName { get; set; }
        public virtual List<GetItemDto> Items { get; set; }
    }
}

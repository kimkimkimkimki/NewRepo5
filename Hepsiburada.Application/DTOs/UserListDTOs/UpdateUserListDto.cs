using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Domain.Entities;

namespace Hepsiburada.Application.DTOs.TopListDTOs
{
    public class UpdateUserListDto
    {
        public string ListName { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public virtual List<Item> Items { get; set; }
    }
}

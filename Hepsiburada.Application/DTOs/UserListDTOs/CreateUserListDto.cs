using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiburada.Application.DTOs.TopListDTOs
{
    public class CreateUserListDto
    {
        public string ListName { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}

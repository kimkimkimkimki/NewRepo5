using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiburada.Application.DTOs.ItemDTOs
{
    public class CreateItemDto
    {
        public int ProductId { get; set; }
        public double DiscountedPrice { get; set; }
        public int TopListId { get; set; }
    }
}

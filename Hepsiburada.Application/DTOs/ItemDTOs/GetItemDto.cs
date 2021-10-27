using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.ProductDTOs;
using Hepsiburada.Domain.Entities;

namespace Hepsiburada.Application.DTOs.ItemDTOs
{
    public class GetItemDto
    {
        public GetProductDto Product { get; set; }
        public double DiscountedPrice { get; set; }
        public int TopListId { get; set; }
    }
}

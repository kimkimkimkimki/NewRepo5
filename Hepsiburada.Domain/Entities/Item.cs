using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Domain.Base_Entity;

namespace Hepsiburada.Domain.Entities
{
    public class Item:BaseEntity
    {
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public double DiscountedPrice { get; set; }
        public int TopListId { get; set; }
        [ForeignKey("TopListId")]
        public UserList TopList { get; set; }
    }
}

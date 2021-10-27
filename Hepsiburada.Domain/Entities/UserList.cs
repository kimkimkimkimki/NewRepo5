using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Domain.Base_Entity;

namespace Hepsiburada.Domain.Entities
{
    public class UserList:BaseEntity
    {
        public string ListName { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public virtual IEnumerable<Item> Items { get; set; }
    }
}

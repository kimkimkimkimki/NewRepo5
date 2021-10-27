using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiburada.Domain.Entities
{
    public class TopTenListForUser
    {
        public string Id { get; set; }
        public User User { get; set; }
        public TopTenList TopTenList { get; set; }
    }
}

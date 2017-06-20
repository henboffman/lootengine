using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models
{
    class Auction
    {
        public int Id{ get; set; }
        public int ItemId{ get; set; }
        public DateTime Created{ get; set; }
        public string CreatedBy{ get; set; }
        public int CurrentBid { get; set; }
        public int Buyout { get; set; }

    }
}

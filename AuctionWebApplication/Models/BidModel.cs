using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebApplication.Models
{
    public class BidModel
    {
        public int ItemNumber { get; set; }
        public long Price { get; set; }
        public string CustomName { get; set; }
        public string CustomPhone { get; set; }
    }
}

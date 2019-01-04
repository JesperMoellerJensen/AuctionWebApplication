using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebApplication.Models
{
    public class AuctionItemModel
    {
        public int ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public long RatingPrice { get; set; }


        public long BidPrice { get; set; }
        public string BidCustomName { get; set; }
        public string BidCustomPhone { get; set; }
        public DateTime BidTimeStamp { get; set; }
    }
}

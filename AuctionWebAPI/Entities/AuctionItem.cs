using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebAPI.Entities
{
    public class AuctionItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemNumber { get; set; }
        [Required]
        public string ItemDescription { get; set; }
        [Required]
        public long RatingPrice { get; set; }


        public long BidPrice { get; set; }
        public string BidCustomName { get; set; }
        public string BidCustomPhone { get; set; }
        public DateTime BidTimeStamp { get; set; }

    }
}

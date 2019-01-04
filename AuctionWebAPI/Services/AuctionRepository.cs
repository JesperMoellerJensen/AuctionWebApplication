using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionWebAPI.Entities;
using AuctionWebAPI.Models;

namespace AuctionWebAPI.Services
{
    public class AuctionRepository : IAuctionRepository
    {
        private AuctionContext _context;

        public AuctionRepository(AuctionContext context)
        {
            _context = context;
        }

        public List<AuctionItem> GetAllAuctionItems()
        {
            return _context.AuctionItems.OrderBy(a => a.ItemNumber).ToList();
        }

        public AuctionItem GetAuctionItem(int itemNumber)
        {
            return _context.AuctionItems.FirstOrDefault(a => a.ItemNumber == itemNumber);
        }

        public void ApplyBid(Bid bid)
        {
            var auctionItem = _context.AuctionItems.FirstOrDefault(a => a.ItemNumber == bid.ItemNumber);
            auctionItem.BidPrice = bid.Price;
            auctionItem.BidCustomName = bid.CustomName;
            auctionItem.BidCustomPhone = bid.CustomPhone;
            auctionItem.BidTimeStamp = DateTime.Now;
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}

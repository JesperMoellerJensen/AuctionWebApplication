using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionWebAPI.Entities;
using AuctionWebAPI.Models;

namespace AuctionWebAPI.Services
{
    public interface IAuctionRepository
    {
        List<AuctionItem> GetAllAuctionItems();
        AuctionItem GetAuctionItem(int itemNumber);
        void ApplyBid(Bid bid);
        bool Save();

    }
}

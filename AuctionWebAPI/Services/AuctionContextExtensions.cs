using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionWebAPI.Entities;

namespace AuctionWebAPI.Services
{
    public static class AuctionContextExtensions
    {
        public static void EnsureSeedDataForContext(this AuctionContext context)
        {
            if (context.AuctionItems.Any())
            {
                return;
            }

            var auctionItems = new List<AuctionItem>
            {
                new AuctionItem
                {
                    ItemDescription = "PH 5 Classic lampe Hvid mat",
                    RatingPrice = 2100
                },
                new AuctionItem
                {
                    ItemDescription = "KRK Højtaler sort",
                    RatingPrice = 5600
                },
                new AuctionItem
                {
                    ItemDescription = "Nokia 3610 vintage edition",
                    RatingPrice = 10299
                },
                new AuctionItem
                {
                    ItemDescription = "Ikea stol hvid",
                    RatingPrice = 399
                }
            };

            context.AddRange(auctionItems);
            context.SaveChanges();
        }
    }
}

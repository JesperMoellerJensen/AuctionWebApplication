using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionWebAPI.Entities;
using AuctionWebAPI.Models;
using AuctionWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuctionWebAPI.Controllers
{
    [Route("api/auctions")]
    public class AuctionController : Controller
    {
        private IAuctionRepository _auctionRepository;

        public AuctionController(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }

        [HttpGet]
        public IActionResult GetAllAuctionItems()
        {
            return Ok(_auctionRepository.GetAllAuctionItems());
        }

        [HttpGet("{itemNumber}")]
        public IActionResult GetAuctionItem(int itemNumber)
        {
            var auctionItem = _auctionRepository.GetAuctionItem(itemNumber);
            if (auctionItem == null)
            {
                return NotFound();
            }

            return Ok(auctionItem);
        }

        [HttpPost("provideBid")]
        public string ProvideBid([FromBody] Bid bid)
        {
            if (bid == null)
            {
                return "Kan ikke omdanne til bid";
            }

            var auctionItem = _auctionRepository.GetAuctionItem(bid.ItemNumber);
            if (auctionItem == null)
            {
                return "Varen findes ikke";
            }

            if (auctionItem.BidPrice > bid.Price)
            {
                return "Bud for lavt";
            }

            _auctionRepository.ApplyBid(bid);
            if (!_auctionRepository.Save())
            {
                return "A problem happened while handling your request";
            }   

            return "Ok";
        }

    }
}

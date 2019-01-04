﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionWebApplication.Helpers;
using AuctionWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuctionWebApplication.Controllers
{
    public class AuctionController : Controller
    {
        private IApiHelper _apiHelper;

        public AuctionController(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
            _apiHelper.BaseUri = new Uri("http://localhost:57395");
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var auctionItemModelsResult = _apiHelper.Get<List<AuctionItemModel>>("api/auctions");
            return View(auctionItemModelsResult);
        }

        public IActionResult Details(int itemNumber)
        {
            var test = itemNumber;
            var auctionItemModelResult = _apiHelper.Get<AuctionItemModel>("api/auctions/" + itemNumber);
            return View(auctionItemModelResult);
        }
    }
}

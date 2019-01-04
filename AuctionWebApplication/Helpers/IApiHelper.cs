using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebApplication.Helpers
{
    public interface IApiHelper
    {
        Uri BaseUri { get; set; }
        T Get<T>(string query);
        bool Post<T>(T data, string query);
    }
}

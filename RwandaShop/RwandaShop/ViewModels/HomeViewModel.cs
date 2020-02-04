using System.Collections;
using System.Collections.Generic;
using RwandaShop.Models;

namespace RwandaShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Shop> Shops { get; set; }
    }
}
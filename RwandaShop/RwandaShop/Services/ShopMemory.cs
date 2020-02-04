using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RwandaShop.Models;

namespace RwandaShop.Services
{
    class ShopMemory : IShop
    {
        public ShopMemory()
        {
            _shops = new List<Shop>
            {
                new Shop{Id=12,Name = "Accessories",Description = "were"},
                new Shop{Id=13,Name = "ShoesShop",Description = "jfjfj"}
                
            };
        }

        public IEnumerable<Shop> GetAll()
        {
            return _shops;
        }

        public Shop Get(int id)
        {
            return _shops.FirstOrDefault(r=>r.Id==id);
        }

        public void Add(Shop newShop)
        {
            newShop.Id = _shops.Max(r => r.Id) + 1;
            _shops.Add(newShop);
        }

        public void Delete(int id)
        {
            Shop shop;
            shop = _shops.FirstOrDefault(r => r.Id == id);
            _shops.Remove(shop);
        }

        public void Edit(int id, Shop shop)
        {
            Shop hop;
            hop = _shops.FirstOrDefault(r=>r.Id==id);
            hop = shop;

            var index=_shops.FindIndex(c=>c.Id==1);
            _shops[index] = hop;
        }

        private static List<Shop> _shops;
    }
}
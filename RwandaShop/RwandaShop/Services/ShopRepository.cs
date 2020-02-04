using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RwandaShop.Models;

namespace RwandaShop.Services
{
    public class ShopRepository:IShop
    {
        private readonly ShopContext _context;

        public ShopRepository(ShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Shop> GetAll()
        {
            return _context.Shops.ToList();
        }
        public Shop Get(int id)
        {
            return _context.Shops.FirstOrDefault(m => m.Id == id);
        }

        public void Add(Shop newShop)
        {
            _context.Add(newShop);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Shop shop;
            shop = _context.Shops.FirstOrDefault(m => m.Id == id);
            _context.Remove(shop);
            _context.SaveChanges();
        }

        public void Edit(int id, Shop shop)
        {
            Shop hop;
            hop = _context.Shops.FirstOrDefault(m => m.Id == id);
            _context.Update(hop);
            _context.SaveChanges();
        }
    }
}
using System.Collections.Generic;
using RwandaShop.Models;

namespace RwandaShop.Services
{
    public interface IShop
    {
        IEnumerable<Shop> GetAll();
        Shop Get(int id);

        void Add(Shop newShop);

        void Delete(int id);
        void Edit(int id, Shop shop);
    }
}
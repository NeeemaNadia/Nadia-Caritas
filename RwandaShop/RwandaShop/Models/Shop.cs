using System;
using System.ComponentModel.DataAnnotations;

namespace RwandaShop.Models
{
    public enum ShopType
    {
        None,
        Accessories,
        ClothesShop,
        ShoesShop
    }
    public class Shop
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ShopType Type { get; set; }
    }
}
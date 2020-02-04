using System.ComponentModel.DataAnnotations;
using RwandaShop.Models;

namespace RwandaShop.ViewModels
{
    public class ShopEditViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ShopType Type { get; set; }
    }
}
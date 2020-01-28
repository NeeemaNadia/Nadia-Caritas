using System.Collections.Generic;
using RestaurantCRUD.Models;

namespace RestaurantCRUD.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
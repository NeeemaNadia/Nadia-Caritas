using System.ComponentModel.DataAnnotations;
using RestaurantCRUD.Models;

namespace RestaurantCRUD.ViewModels
{
    /**/
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Service.ViewModels
{
    public class ProductViewModel
    {
        public string Id { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public double Price { get; set; }
        public string ImagePath { get; set; } = String.Empty;
        public FastFoodVolume FastFoodVolume { get; set; }
    }
}

using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities.Products
{
    public class TypeFastFood : Base
    {
        public string Name { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public float Price { get; set; }
        public FastFoodVolume FastFoodVolume { get; set; }
        public string CategoryFastFoodId { get; set; } = string.Empty;
        public virtual CategoryFastFood CategoryFastFood { get; set; } = default!;
    }
}

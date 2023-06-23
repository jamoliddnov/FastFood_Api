using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class TypeFastFood : Base
    {
        public string FastFoodName { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;
        public float Price { get; set; }
        public FastFoodVolume FastFoodVolume { get; set; }
        public Guid CategoryFastFoodId { get; set; }
        public virtual CategoryFastFood CategoryFastFood { get; set; } = default!;
    }
}

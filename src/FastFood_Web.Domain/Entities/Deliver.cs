using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Deliver : Base
    {
        public string CarModel { get; set; } = String.Empty;
        public string CarNumber { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;
        public string DistrictFilialId { get; set; } = String.Empty;
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
        public string UserId { get; set; } = String.Empty;
        public virtual User User { get; set; } = default!;
    }
}

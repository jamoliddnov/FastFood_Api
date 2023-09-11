using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities.Empolyees
{
    public class Deliver : Base
    {
        public string CarModel { get; set; } = string.Empty;
        public string CarNumber { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string DistrictFilialId { get; set; } = string.Empty;
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
        public string UserId { get; set; } = string.Empty;
        public virtual User User { get; set; } = default!;
    }
}
